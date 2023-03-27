using System;

class Program
{
    static void Main()
    {
        int[] A = { 5, 7, 13, 19, 24, 35, 42 };
        int key, i = 0;
        bool durum = true;

        Console.WriteLine("Aranicak degeri giriniz: ");
        key = int.Parse(Console.ReadLine());

        while (i < A.Length)
        {
            if (A[i] == key)
            {
                Console.WriteLine("Deger bulundu. {0}. indistedir.", i);
                durum = false;
                break;
            }
            else
                Console.WriteLine("{0} esit degildir {1} Aranmaya devam ediliyor...", A[i], key);
            i++; // i = i + 1 veya i += 1
        }

        if (durum)
            Console.WriteLine("Aranan deger bulunamamistir.");

        Console.ReadKey();
    }
}