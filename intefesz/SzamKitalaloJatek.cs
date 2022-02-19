using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intefesz
{
    internal class SzamKitalaloJatek
    {
        Random rnd = new Random();
        const int MAX_VERSENYZO = 3; 
        ITippelo[] versenyzok = new ITippelo[MAX_VERSENYZO];
        int versenyzokN = 0;
        public void VersenyzoFelvetele(ITippelo versenyzo)
        {
            versenyzok[versenyzokN] = versenyzo;
            versenyzokN++;
        }
        int alsoHatar = 10, felsoHatar = 20, cel;
        public SzamKitalaloJatek(int also, int felso)
        {
            this.alsoHatar = also;
            this.felsoHatar = felso;
        }
        public SzamKitalaloJatek()
        {

        }
        public void VersenyIndul()
        {   
            cel = rnd.Next(alsoHatar,felsoHatar);
            foreach(var a in versenyzok)
                a.JatekIndul(alsoHatar, felsoHatar);
        }
        public bool JavitottMindenkiTippel()
        {
            bool winlose = false;
            double[] lasttipp = new double[versenyzok.Length];
            for(int i = 0; i < versenyzok.Length; i++)
            {
                double tip = versenyzok[i].KovetkezoTipp();
                tip = Math.Round(tip);
                lasttipp[i] = tip;
                if(tip == cel)
                {
                    versenyzok[i].Nyert();
                    winlose = true;
                }else if(versenyzok[i] is IOkostippelo)
                {
                    if (tip > cel)
                        (versenyzok[i] as IOkostippelo).Nagyobb();
                    if (tip < cel)
                        (versenyzok[i] as IOkostippelo).Nagyobb();
                }
            }
            if(winlose)
            {
                for(int i = 0;i < versenyzok.Length;i++)
                {
                    if (lasttipp[i] != cel)
                        versenyzok[i].Veszitett();
                }
            }
            return winlose;
        }
        public bool MindenkiTippel()
        {
            Console.WriteLine("cel :" + cel);
            //w ha egynél több ember nyer akkor mindenki nyer
            //Ha min 1 ember nyer akkor mindenki aki nem találta el az veszít
            int nyertesek =0 ;
            foreach(var a in versenyzok)
            {
                nyertesek = 0;
                double tip = a.KovetkezoTipp();
                tip = Math.Round(tip);
                if (tip == cel)
                {
                    nyertesek++;
                    (a as GepiJatekos).Nyert();
                    Console.WriteLine("NYERTEEEEEEem");
                }
                else
                {
                    Console.WriteLine("Nem nyert"); 
                    a.Veszitett();
                    if(a is IOkostippelo)
                    {// hogy ha megvalositja az interface-t
                        if (tip <= cel)
                            (a as IOkostippelo).Kisebb();
                        if(tip >= cel)
                            (a as IOkostippelo).Nagyobb();
                    }
                }

            }
            if(nyertesek > 1)
            {
                foreach (var a in versenyzok)
                    (a as GepiJatekos).Nyert();
            }
            return nyertesek > 0;
        }
        public virtual void Jatek()
        {
            VersenyIndul();
            bool temp = false;
            while (temp == false)  temp = JavitottMindenkiTippel();
        }
        public void Statisztika(int korokSzama)
        {

            foreach(var a in versenyzok)
                a.JatekIndul(alsoHatar,felsoHatar);
            for(int i = 0; i < korokSzama; i++)
            {
                Jatek();
            }
            foreach(var a in versenyzok)
            {
                if(a is IStatisztikatSzolgaltat)
                {
                    IStatisztikatSzolgaltat nezett = (a as IStatisztikatSzolgaltat);
                    Console.WriteLine( nezett.GetType() + " Ny: " + nezett.HanyszorNyert() + " V: " + nezett.HanyszorVesztett());
                }
            }
        }
    }
}
