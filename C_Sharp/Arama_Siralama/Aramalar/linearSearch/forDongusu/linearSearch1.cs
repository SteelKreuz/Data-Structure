using System;

class Program
{
    static void Main()
    { // duz bir, for dongusu ile yapilmis linear search algoritmasi.
        int[] A = { 3, 7, 11, 19, 24, 35, 47 };
        bool durum = true; // aranan degerin bulunamamasi durumunda, kullanciya bildirmek icin
                           // bir degisken kullaniyoruz.
        int key;

        Console.WriteLine("Aranicak sayiyi giriniz: ");
        key = int.Parse(Console.ReadLine());

        for (int i = 0; i < A.Length; i++)
        { // diziyi, bastan sona inceliyoruz.
            if (A[i] == key) // A dizisinde, i'ninci indisteki deger; aranan degere esitse
            {               // ekrana yazdirip cikiyoruz.
                Console.WriteLine("{0} = {1} Sayi bulundu...", A[i], key);
                durum = false; // sayi bulundugu icin bu degiskeni false yapiyoruz. 
                break;
            }
            else // deger bulunamazsa islem devam eder...
                Console.WriteLine("{0} esit degildir {1} islem devam ediyor...", A[i], key);
        }
        // aranan deger bulunamadiysa, kullanciya bildirilir.
        if (durum)
            Console.WriteLine("Sayi bulunamamistir...");

        Console.ReadKey();
    }
}   