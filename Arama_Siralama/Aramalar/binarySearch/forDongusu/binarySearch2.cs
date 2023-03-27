using System;

class Program
{
    // For dongusu ile yapilmis fonksiyon icinde binary search algoritmasi
    public static int binarySearch(int[] dz, int key)
    {
        int bas, son = dz.Length - 1, orta;

        for (bas = 0; bas <= son;)
        {
            orta = (bas + son) / 2;
            if (dz[orta] == key)
                return orta;
            else if (dz[orta] < key)
                bas = orta + 1;
            else if (dz[orta] > key)
                son = orta - 1;
        }

        return -1;
    }
    static void Main(string[] args)
    {
        int[] A = { 3, 7, 16, 28, 47, 56, 71, 5, 21 };
        int key, sonuc;

        Array.Sort(A);
        // sirali halini gormek icin:
        //for (int i = 0; i < A.Length; i++)
        //    Console.WriteLine("{0} - {1}", i, A[i]);

        Console.WriteLine("Aranicak degeri girin: ");
        key = int.Parse(Console.ReadLine());

        sonuc = binarySearch(A, key);

        if (sonuc == -1)
            Console.WriteLine("Aranan deger bulunamadi.");
        else
            Console.WriteLine("Aranan deger {0}. indistedir", sonuc);

        Console.ReadKey();
    }
}