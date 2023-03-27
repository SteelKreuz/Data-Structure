using System;

namespace HelloWorld
{
    class Program
    {
        public static void Yazdir(Dugum baslangic)
        {
            var mevcutVagon = baslangic;
            while(mevcutVagon != null) // mevcutVagon bos mu degil mi diye kontrol ediyoruz.
            {   // Liste sonuna gelip gelmedigini kontrol ediyoruz.
                if(mevcutVagon.Sonraki != null)
                {   // Gelmediyse normal yazdiriyoruz.
                    Console.Write(mevcutVagon.Veri + " -> ");
                    mevcutVagon = mevcutVagon.Sonraki;
                }
                else
                {   // Geldiyse " -> " isaretini yazdirmiyoruz.
                    Console.WriteLine(mevcutVagon.Veri);
                    mevcutVagon = mevcutVagon.Sonraki;
                }
            }
        }
        public static void Main()
        {
            var vagonBir = new Dugum("1. vagon");
            var vagonIki = new Dugum("2. vagon");
            var vagonUc = new Dugum("3. vagon");
            var vagonDort = new Dugum("4. vagon");

            vagonBir.Sonraki = vagonIki;
            vagonIki.Sonraki = vagonUc;
            vagonUc.Sonraki = vagonDort;

            Yazdir(vagonBir);

            Console.ReadKey();
        }
    }
}