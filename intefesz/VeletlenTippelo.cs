using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intefesz
{
    internal class VeletlenTippelo : GepiJatekos
    {
        public override int KovetkezoTipp()
        {
            Random random = new Random();
            return random.Next(alsoHatar, felsoHatar);
        }
    }
}
