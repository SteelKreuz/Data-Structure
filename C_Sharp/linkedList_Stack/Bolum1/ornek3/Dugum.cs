using System;

namespace HelloWorld
{
    class Dugum
    {
        // Veri ve isaretcileri (Sonraki) private olan dugum tanimi

        private string Veri;
        private Dugum Sonraki;

        public Dugum(string veri)
        {
            Veri = veri;
            Sonraki = null;
        }
        public void Yazdir(Dugum n1, Dugum n2, Dugum n3, Dugum n4)
        {
            n1.Sonraki = n2;
            n2.Sonraki = n3;
            n3.Sonraki = n4;
            var mevcut = n1;
            while(mevcut != null)
            {
                if(mevcut.Sonraki != null)
                {
                    Console.Write(mevcut.Veri + " -> ");
                    mevcut = mevcut.Sonraki;
                }
                else
                {
                    Console.WriteLine(mevcut.Veri);
                    mevcut = mevcut.Sonraki;
                }
            }
        }
    }
}
