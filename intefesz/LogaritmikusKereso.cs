using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intefesz
{
    internal class LogaritmikusKereso : GepiJatekos, IOkostippelo
    {
        int center = 0;
        public override int KovetkezoTipp()
        {
            elozoTipp = center;
            center = (alsoHatar + felsoHatar) / 2;
            return center;
        }
        public void Kisebb()
        {
            felsoHatar = elozoTipp; // at álitani az előző tippre
        }
        public void Nagyobb()
        {
            alsoHatar = elozoTipp; // át álítani az előző tippre
        }
    }
}
