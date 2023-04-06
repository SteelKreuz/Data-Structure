using System;

namespace HelloWorld
{
    class Dugum
    {
        public string Veri;
        public Dugum Sonraki;

        public Dugum(string veri)
        {
            Veri = veri;
            Sonraki = null;
        }
    }
}
