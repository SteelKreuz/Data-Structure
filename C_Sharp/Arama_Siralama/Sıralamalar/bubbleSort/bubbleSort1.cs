using System;

class Program
{
    static void Main()
    {
        int[] A = { 21, 63, 14, 39, 5, 17, 2, 41 };
        int dzUz = A.Length; // dizinin uzunlugunu aldik.

        for (int n = 0; n < dzUz; n++) // ekrana siralanmamis halini yazdirdik.
            Console.WriteLine("{0}. indis =  {1}", n, A[n]);

        Console.WriteLine("--------");

        for (int i = dzUz - 1; i > 0; i--) // diziyi sondan her defasinde bir eksilterek kontrol edicez.
        {
            for (int j = 0; j < i; j++)   // diziyi bastan baslatiyoruz ve j degerinden i kadar sondan kisaltarak
            {                             // donguyu devam ettiriyoruz
                if (A[j] > A[j + 1]) // 1. eleman, 2. elemandan buyukse, 2. eleman kucuktur ve yer degisir.
                {
                    int temp = A[j]; // 1. eleman kaybolmasin diye gecici degiskene atilir.
                    A[j] = A[j + 1]; // 2. eleman, 1. elemana atilir.
                    A[j + 1] = temp; // gecici degiskendeki 1. eleman, 2. elemana atilir.
                }
                for (int n = 0; n < dzUz; n++) // her dongude, dizinin durumu ekrana gosterilir
                {
                    if (A[n] == A[j])
                        Console.WriteLine("------ ** {0}. indis =  {1} ** <-- su an burada ve {2} ile {3} karsilastiriliyor", n, A[n], A[n], A[n + 1]);
                    else
                        Console.WriteLine("{0}. indis = {1}", n, A[n]);
                }
                Console.WriteLine("-------"); // eger secilen 1. eleman (x) ile 2. eleman (y) siraliysa (x < y) aynen devam eder donguye.
            }                                 // herhangi bir degisiklik yapilmaz.
        }

        for (int i = 0; i < dzUz; i++) // son halini ekrana yazdirir.
            Console.WriteLine("{0}. indis = {1}", i, A[i]);

        Console.ReadKey();
    }
}