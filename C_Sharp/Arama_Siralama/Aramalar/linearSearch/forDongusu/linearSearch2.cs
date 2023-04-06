using System;

class Program
{       // fonksiyon halinde kullanilan, for dongusu ile yapilmis bir linear search algoritmasi.
    public static int linearSearch(int[] dz, int key)
    {
        for (int i = 0; i < dz.Length; i++)
            if (dz[i] == key) // aranan deger bulunursa
                return i; // hangi indisteyse, o indisi geri dondururuz.

        return -1; // bulunamazsa, sonuc yok anlaminda -1 dondurulur.
    }
    static void Main(string[] args)
    {
        int[] A = { 3, 7, 11, 19, 24, 35, 47 };
        int key, sonuc;

        Console.WriteLine("Aramak istediginiz degeri yazin: ");
        key = int.Parse(Console.ReadLine());

        sonuc = linearSearch(A, key);

        if (sonuc == -1)
            Console.WriteLine("Aranan deger bulunamamistir...");
        else
            Console.WriteLine("Aranan deger dizinin {0}. indisindedir.", sonuc);

        Console.ReadKey();
    }
}