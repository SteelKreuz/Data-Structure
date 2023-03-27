using System;

class Program
{ // selection sort algoritmasi
    static void Main()
    {
        static void Main(string[] args)
        {
            int[] A = { 18, 2, 35, 25, 1, 63, 49 };
            int enKucuk, dzUz = A.Length; // Dizi uzunlugu dzUz degiskeninde tutulacak.
            bool durum = false;           // Dizi zaten sirali mi degil mi, diye, bu degisken ile anlayabiliriz.
            for (int i = 0; i < dzUz - 1; i++) // i degiskeni, dizi uzunlugundan 1 eksik olana kadar devam edicektir
            { // Yani; dizi 7 elemanli ise dzUz - 1 = 6 olur. 1. dongude son durum (i = 5) ise i < (7 - 1) dogru olacaginden devam eder.
                enKucuk = i; // enKucuk degisken de i'nin, o dongudeki degerini tutuyoruz ve eger icteki dongude 
                             // if bloguna girerse, j degerini tutucak.
                int temp; // temp, temporary yani gecici degiskendir.
                for (int j = i + 1; j < dzUz; j++) // son durumda J = (5 + 1) olur. 5 < 7 ise devam eder.
                {
                    if (A[enKucuk] > A[j]) // (enKucuk = i) degeri 5 idi. A[5] > A[6]
                    { // 6. indisteki deger kucuk demektir. ve yer degistirir.
                        enKucuk = j; // 20. satirdaki islemi yapiyor.
                        durum = true; // dizimiz sirali degilmis. bunu belirtiyoruz.
                    }
                }
                // bu bir swapping islemidir.
                if (durum) // icerdeki dongu en kucugu bulursa, buraya giricek. bulamazsa girmicek.
                {          // cunku, bulamazsa zaten en kucugu basta demektir...
                    temp = A[i];       // 1. elemanı yani i'ninci indisteki degeri kaybolmasin diye temp'e atadik.
                    A[i] = A[enKucuk]; // 1. elemana, buldugumuz en kucuk elemani atiyoruz. burada 1. eleman kaybolur ve A[i] = A[enKucuk]
                    A[enKucuk] = temp; // en kucuk elemanin oldugu indise yani dizideki yere temp'teki degeri atiyoruz.
                }
            }

            for (int i = 0; i < A.Length; i++)
                Console.WriteLine("{0}. indis = {1}", i, A[i]);

            Console.ReadKey();
        }
    }
}