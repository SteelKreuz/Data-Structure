/*
 *      Ornek2'nin Turkce degiskenli halidir.
 *      Daha temiz bir kod dosyasi.
 * *****************************************************/

using System;

namespace example
{
    class Program
    {
        static void Main(string[] args)
        {
            BagliListe erisim = new BagliListe();
            erisim.Yaz();
            erisim.Ekle("Bursa");
            erisim.Yaz();
            erisim.GeriYaz();
            erisim.Ekle("Bilecik");
            erisim.Yaz();
            erisim.GeriYaz();
            erisim.Ekle("Eskisehir");
            erisim.Yaz();
            erisim.GeriYaz();

            erisim.BasaEkle("Balikesir");
            erisim.Yaz();
            erisim.GeriYaz();

            erisim.ArdindanEkle("Bilecik", "Bozyuk");
            erisim.Yaz();
            erisim.GeriYaz();

            erisim.SonaEkle("Angara");
            erisim.Yaz();
            erisim.GeriYaz();

            erisim.VeriIleSil("Angara");
            erisim.Yaz();
            erisim.GeriYaz();

            erisim.IndexIleSil(3); // girilen eleman sayisindan, buyuk sayi girmeyi yapmadim.
            erisim.Yaz();          // onu siz yapabilirsiniz :)
            erisim.GeriYaz();
            Console.ReadKey();
        }
    }
}
