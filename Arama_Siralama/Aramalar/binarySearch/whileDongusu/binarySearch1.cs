using System;

class Program
{   // While dongusu ile binary search algoritmasi
    static void Main()
    {
        int[] A = { 3, 5, 9, 18, 26, 47, 54 };
        int bas = 0, son = A.Length - 1, orta, key;
        bool durum = true;

        Array.Sort(A);

        Console.WriteLine("Aranicak degeri giriniz: ");
        key = int.Parse(Console.ReadLine());

        while (bas <= son)
        {
            orta = (bas + son) / 2;
            if (A[orta] == key)
            {
                Console.WriteLine("Aranan deger bulundu! {0}. indistedir", orta);
                durum = false;
                break;
            }
            else if (A[orta] < key)
            {
                bas = orta + 1;
                Console.WriteLine("{0} < {1} daha buyuk deger araniyor...", A[orta], key);
            }
            else if (A[orta] > key)
            {
                son = orta - 1;
                Console.WriteLine("{0} > {1} daha kucuk deger araniyor...", A[orta], key);
            }
        }

        if (durum)
            Console.WriteLine("Aranan deger bulunamadi.");

        Console.ReadKey();
    }
}