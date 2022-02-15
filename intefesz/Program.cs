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
            while(szkj.MindenkiTippel() == true)
            ;
        }
        static void Main(string[] args)
        {
            test1();
        }
    }
}
