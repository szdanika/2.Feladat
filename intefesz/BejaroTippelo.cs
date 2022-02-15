using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intefesz
{
    internal class BejaroTippelo : GepiJatekos
    {
        protected int aktualis = 10;
        public override void JatekIndul(int ahatar, int felhatar)
        {
            base.JatekIndul(aktualis,felhatar);
        }
        public override int KovetkezoTipp()
        {
            int temp = aktualis;
            aktualis++;
            return temp;
        }
    }
}
