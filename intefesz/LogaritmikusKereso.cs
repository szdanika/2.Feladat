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
            if (center == 0)
                elozoTipp = (alsoHatar + felsoHatar) / 2;
            center = (alsoHatar + felsoHatar) / 2;
            Console.WriteLine("also :" + alsoHatar + " felso :" + felsoHatar);
            return center;
        }
        public void Kisebb()
        {
            alsoHatar = elozoTipp; // at álitani az előző tippre
        }
        public void Nagyobb()
        {
            felsoHatar = elozoTipp; // át álítani az előző tippre
        }
    }
}
