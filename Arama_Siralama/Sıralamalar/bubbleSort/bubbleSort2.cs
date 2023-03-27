using System;

class Program
{   // fonksiyon icinde bubble sort yazimi
    public static int[] bubbleSort(int[] dz)
    {
        for (int i = dz.Length - 1; i > 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                if (dz[j] > dz[j + 1])
                {
                    int temp = dz[j];
                    dz[j] = dz[j + 1];
                    dz[j + 1] = temp;
                }
            }
        }

        return dz;
    }

    static void Main()
    {
        int[] A = { 21, 63, 14, 35, 5, 17, 2, 41 };

        for (int i = 0; i < A.Length; i++)
            Console.WriteLine("{0}. indis = {1}", i, A[i]);
        Console.WriteLine("------");
        A = bubbleSort(A);
        for (int i = 0; i < A.Length; i++)
            Console.WriteLine("{0}. indis = {1}", i, A[i]);

        Console.ReadKey();
    }
}