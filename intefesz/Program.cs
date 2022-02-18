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
        public static void test2()
        { // logaritmus teszt
            SzamKitalaloJatek szkj = new SzamKitalaloJatek();
            LogaritmikusKereso lgk = new LogaritmikusKereso();
            szkj.VersenyzoFelvetele(lgk);
            //BejaroTippelo bt = new BejaroTippelo();
            //szkj.VersenyzoFelvetele(bt);
            szkj.VersenyIndul();
            bool temp = false;
            while (temp == false)
                temp = szkj.MindenkiTippel();
            ;
        }
        public static void test3()
        {//emberteszt
            EmberiJatekos ember = new EmberiJatekos();
            SzamKitalaloJatek szkj = new SzamKitalaloJatek();
            szkj.VersenyzoFelvetele(ember);
            szkj.VersenyIndul();
            bool temp = false;
            while (temp == false)
                temp = szkj.MindenkiTippel();

        }
        static void Main(string[] args)
        {
            test2();
        }
    }
}
