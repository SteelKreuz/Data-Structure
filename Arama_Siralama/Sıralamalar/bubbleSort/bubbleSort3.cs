using System;

class Program
{   // tersten isleyen bir bubble sort algoritmasi ve optimize edilmis hali
    static void Main()
    {
        int[] A = { 21, 63, 14, 35, 5, 17, 2, 41 }; // siralanmamis bir dizi
     // int[] A = { 2, 3, 5, 11, 19, 25, 41};       // sirali bir dizi
        int sayac = 0;
        for (int i = 0; i < A.Length; i++) // diziyi ekrana yazdiriyoruz.
            Console.WriteLine("{0} - {1}", i, A[i]);

        Console.WriteLine("----------");
        for (int i = 0; i < A.Length; i++) // diziyi sol taraftan kisaltarak gereksiz islemleri engellemis oluyor.
        {
            bool sirali = true; // sirali bir dizimiz varsa, gereksiz adimi onlemek icin bu degiskeni tanimliyoruz.
            for (int j = A.Length - 1; j > i; j--) // sondan baslayarak diziyi kontrol ediyor.
            { // 8 elemanli dizimizde:
                if (A[j - 1] > A[j]) // bir onceki elemanla, j'ninci elemani karsilastiriyoruz.
                {                    // eger j'ninci eleman kucukse, buyukle yer degistiriyor.
                    sirali = false;      // buraya girdiyse, sirali bir dizimiz yok demektir.
                    int temp = A[j - 1]; // buyuk olani, gecici degiskene atarak yedekliyor.
                    A[j - 1] = A[j];     // buyuk olana, kucuk olan degeri atiyor.
                    A[j] = temp;         // kucuk olana, 22. satirdaki atanan, buyuk degeri atiyoruz.

                    for (int n = 0; n < A.Length; n++) // Her swapping isleminden sonra diziyi ekrana yazdiriyoruz.
                        Console.WriteLine("{0} - {1}", n, A[n]);

                    Console.WriteLine("----------");
                }
                sayac++;
            }
            sayac++;
            if (sirali) // verilen dizi, sirali ise direkt donguden cikar.
                break;
        }

        for (int i = 0; i < A.Length; i++) // Son halini ekrana yazdiriyoruz.
            Console.WriteLine("{0} - {1}", i, A[i]);

        Console.WriteLine("----------");

        Console.WriteLine("{0} kere islem yapildi", sayac);
        Console.ReadKey();
    }
}