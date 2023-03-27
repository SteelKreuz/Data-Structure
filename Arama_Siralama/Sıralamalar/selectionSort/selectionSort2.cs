using System;

class Program
{  // Selection sort, metot ile yapimi

    public static int[] selectinSort(int[] dz)
    {
        int temp, enKucuk, dzUz = dz.Length;
        bool durum = false;
        for (int i = 0; i < dzUz - 1; i++)
        {
            enKucuk = i;
            for (int j = i + 1; j < dzUz; j++)
            {
                if (dz[enKucuk] > dz[j])
                {
                    enKucuk = j;
                    durum = true;
                }
            }
            if (durum)
            {
                temp = dz[i];
                dz[i] = dz[enKucuk];
                dz[enKucuk] = temp;
            }
        }
        return dz;
    }

    static void Main()
    {
        int[] A = { 18, 2, 35, 25, 1, 63, 49 };

        A = selectinSort(A);

        for (int i = 0; i < A.Length; i++)
            Console.WriteLine("{0}. indis = {1}", i, A[i]);

        Console.ReadKey();
    }
}