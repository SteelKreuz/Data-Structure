using System;

class Program
{
    public static int linearSearch(int[] dz, int key)
    {
        int i = 0;

        while (i < dz.Length)
        {
            if (dz[i] == key)
                return i;

            i++;
        }
        return -1;
    }
    static void Main()
    {
        int[] A = { 5, 7, 2, 6, 11, 24 };
        int key, sonuc;

        Console.WriteLine("Aranicak sayiyi girin: ");
        key = int.Parse(Console.ReadLine());

        sonuc = linearSearch(A, key);

        if (sonuc == -1)
            Console.WriteLine("Aranan deger bulunamamistir.");
        else
            Console.WriteLine("Aranan deger {0}. indistedir.", sonuc);

        Console.ReadKey();
    }
}