using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intefesz
{
    internal class EmberiJatekos : IOkostippelo
    {
        public void JatekIndul(int alhat, int felsohat)
        {
            Console.WriteLine("Kezdődik a játék, felsőhatár :" + felsohat + " , alsóhatár :"+alhat);
        }
        public void Kisebb()
        {
            Console.WriteLine("Az előző tippnél kisebb a keresett szám");
        }
        public void Nagyobb()
        {
            Console.WriteLine("Az előző tippnél nagyobb a keresett szám");
        }
        public int KovetkezoTipp()
        {
            Console.WriteLine("Kérem a következő tippet :");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
