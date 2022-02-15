using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intefesz
{
    abstract class GepiJatekos : ITippelo
    {
        public int ElozoTipp { get => elozoTipp; }
        protected int alsoHatar, felsoHatar;
        public virtual void JatekIndul(int ahatar, int felhatar)
        {
            alsoHatar = ahatar;
            felsoHatar = felhatar;
        }
        int nyertDB=0, veszitettDB=0;
        protected int elozoTipp;
        public void Nyert()
        {
            nyertDB++;
        }
        public void Veszitett()
        {
            veszitettDB++;
        }
        abstract public int KovetkezoTipp();
    }
}
