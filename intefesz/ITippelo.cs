using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intefesz
{
    internal interface ITippelo
    {
        void JatekIndul(int alsoHatar, int FelsoHatar);
        int KovetkezoTipp();
        void Veszitett();
        void Nyert();
    }
}
