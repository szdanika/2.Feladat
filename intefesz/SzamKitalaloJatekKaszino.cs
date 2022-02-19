using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intefesz
{
    internal class SzamKitalaloJatekKaszino : SzamKitalaloJatek, IStatisztikatSzolgaltat
    {
        int kaszinoNyert = 0, kaszinoVesztett = 0, korokszama;
        public SzamKitalaloJatekKaszino(int alsohatar, int felsohatar, int korokszama) : base(alsohatar,felsohatar)
        {
            this.korokszama = korokszama;
        }
        public override void Jatek()
        {
            VersenyIndul();
            for(int i = 0; i < korokszama; i++)
            {
                bool temp = JavitottMindenkiTippel();
                if(temp == false)
                    kaszinoNyert++;
                else
                    kaszinoVesztett++;
            }
            Console.WriteLine("Kaszino : Ny: " + kaszinoNyert + " V:" + kaszinoVesztett);
        }
        public int HanyszorNyert()
        {
            return kaszinoNyert;
        }
        public int HanyszorVesztett()
        {
            return kaszinoVesztett;
        }
    }
}
