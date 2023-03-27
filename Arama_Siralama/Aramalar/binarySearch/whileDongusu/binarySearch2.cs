using System;

class Program
{
    // While dongusu ile fonksiyonlu binary search algoritmasi
    public static int binarySearch(int[] dz, int key)
    {
        int bas = 0, son = dz.Length - 1, orta;

        while (bas <= son)
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
        int[] A = { 3, 5, 9, 18, 26, 47, 54 };
        int key, sonuc;

        Array.Sort(A);

        Console.WriteLine("Aranicak degeri girin: ");
        key = int.Parse(Console.ReadLine());

        sonuc = binarySearch(A, key);

        if (sonuc == -1)
            Console.WriteLine("Aranan deger bulunamadi.");
        else
            Console.WriteLine("Aranan deger {0}. indistedir.", sonuc);

        Console.ReadKey();
    }
}