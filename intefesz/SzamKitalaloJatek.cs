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
        const int MAX_VERSENYZO = 2;
        ITippelo[] versenyzok = new GepiJatekos[MAX_VERSENYZO];
        int versenyzokN = 0;
        public void VersenyzoFelvetele(ITippelo versenyzo)
        {
            versenyzok[versenyzokN] = versenyzo;
            versenyzokN++;
        }
        int alsoHatar = 10, felsoHatar = 20, cel;
        public SzamKitalaloJatek()
        {

        }
        public void VersenyIndul()
        {   
            cel = rnd.Next(alsoHatar,felsoHatar);
            foreach(var a in versenyzok)
                a.JatekIndul(alsoHatar, felsoHatar);
        }
        public bool MindenkiTippel()
        {
            //w ha egynél több ember nyer akkor mindenki nyer
            //Ha min 1 ember nyer akkor mindenki aki nem találta el az veszít
            int nyertesek =0 ;
            foreach(var a in versenyzok)
            {
                nyertesek = 0;
                int tip = a.KovetkezoTipp();
                Console.WriteLine("igen tip : " + tip);
                if (tip == cel)
                {
                    nyertesek++;
                    (a as GepiJatekos).Nyert();
                }
                else
                {
                    (a as GepiJatekos).Veszitett();
                }

            }
            if(nyertesek > 1)
            {
                foreach (var a in versenyzok)
                    (a as GepiJatekos).Nyert();
            }
            return nyertesek > 0;
        }
    }
}
