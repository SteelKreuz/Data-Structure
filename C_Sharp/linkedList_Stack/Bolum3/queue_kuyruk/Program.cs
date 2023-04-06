using System;

//  C# dili pointer icerir ama kullanilmasi izin gerektirir. Pointer yerine referans vardir.
//  Pointer kullanarak standartlarin disina ciktigimiz icin, unmanaged code yazmak zorundayiz.
//  Oncelikle kodun calismasi icin: Sag tarafta solution explorer kismindan proje ismine sag tiklanir.
//  Properties(Ozellikler) -> Build sekmesine gelinir. "Allow unsafe code" kismi secilir.
//  Ve sonra, kodlarimizi yazacagimiz alana unsafe kodunu yazariz. Burada komple sinifi kullandigim icin
//  Sinif'a yazdim.

namespace queue // Queue (sira veya kuyruk)
{
    unsafe class Program
    {
        static public int*[] dizi; // kuyruk icin dizi tanimlandi.
        static public int sira = 0, sirabasi = 0, boyut = 2; 
        // Sira: Her eklenicek veriyi, ilk bos siraya eklemek icin bu degiskeni tanimliyoruz. Daha sira olmadigi icin 0'dır. Yani null (bostur).
        // Ayni zamanda, dizinin boyutunu gecip gecmedigimi kontrol etmemizi sagliyor.
        // Sirabasi: dizinin basindan itibaren, diziden ne kadar veri silindiyse o kadar artar. Dolayisi ile bastan itibaren kac tane veriyi sildigimizi tutan degiskendir.
        // Boyut: dizimizin, o anki boyutunu tutar.

        static public int deque() // Siraya gore kuyruktaki elemanlari gosterir.
        {   // sira: diziye her eleman eklendiginde, eklenen eleman kadar sira degeri artar.
            // sirabasi: dizinin basindan itibaren, cikartilacak elemanlarin sirasini gosterir.
            if (sira == sirabasi) // eklenen veri sayisi, dizi boyutuna geldiyse, dizimiz (siramiz) dolmus demektir.
            {
                Console.WriteLine("Sira Bostur.");
                return -1; // -1 degeri, fonksiyonun hata verdigini, duzgun calismadigini belirtir.
            }      
            // (int) bir type cast islemidir. Tip donusturmak icin kullanilir.
            // Metodumuzun amaci, dizinin en basindan itibaren elemanlari sirasi ile cikarmaktir.
            // "sirabasi++" ifadesi; once sirabasi degiskeninin degeri neyse, dizinin o indisteki degerini return eder ve sirabasi degiskenin degerini 1 arttirir.
            
            return (int)dizi[sirabasi++];
            // burada silme islemi yapmadim. Meraklisi icin soyle yapilabilir:
            /* int sayi = (int)dizi[sirabasi];
             * dizi[sirabasi++] = null;
             * return sayi; */
        }

        static public void enque(int sayi) // Kuyruga sirasi ile veri ekleyen metod.
        {
            if (dizi == null) // dizi bos ise
                dizi = new int*[sizeof(int) * 2]; // dizi icin, bellekte alan olusturur.

            // opsiyoneldir. Dizimizin boyutu dolduysa alan acar.
            if(sira >= boyut) // dizi dolduysa eger
            {
                boyut *= 2; // dizinin boyutu 2 katina cikartilir.
                int*[] dizi2 = new int*[sizeof(int) * boyut]; // eski dizinin 2 kati boyutu olan yeni bir dizi degisken olustururlur.
                for (int i = 0; i < (boyut / 2); i++) 
                    dizi2[i] = dizi[i];   // eski dizideki her veriyi, yeni diziye atar.     
                dizi = null; // eski dizimizi bir nevi yok ediyoruz.
                dizi = dizi2; // olusturulan yeni diziyi, varsayilan dizi degiskenimize devrediyoruz burada. (referans etmek denir buna gercekte)
            }
            dizi[sira++] = (int*)sayi; // dizi degiskenine, sira kactaysa o siradaki indise verimizi(sayimizi) yerlestiriyoruz.
                          // (int*) dizi pointer int olarak tanimlandigi icin, sayiyi ona cevirip atamak zorundayiz!!
        }

        // opsiyoneldir.
        static public void toparla()
        {
            if (sirabasi == 0)
            {
                Console.WriteLine("Sira Bos");
                return;
            }

            for (int i = 0; i < boyut; i++)
                dizi[i] = dizi[i + sirabasi];

            sira -= sirabasi;
            sirabasi = 0;
        }
        public static void Main()
        {
            for (int i = 0; i < 20; i++)
                enque(i * 10);

            for (int i = 0; i < 10; i++)
                Console.WriteLine($"{(int)deque()}");



            Console.Read();
        }
    }
}