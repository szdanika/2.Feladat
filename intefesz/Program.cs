using System;

namespace intefesz
{
    internal class Program
    {
        public static void test1()
        {
            SzamKitalaloJatek szkj = new SzamKitalaloJatek();
            BejaroTippelo bt = new BejaroTippelo();
            szkj.VersenyzoFelvetele(bt);
            VeletlenTippelo vt = new VeletlenTippelo();
            szkj.VersenyzoFelvetele(vt);
            szkj.VersenyIndul();
            bool temp = false;
            while (temp == false)
                temp = szkj.MindenkiTippel();
            ;
        }
        static void Main(string[] args)
        {
            test1();
        }
    }
}
