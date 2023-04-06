using System;

class Program
{   // For dongusu ile yapilmis binary search algoritmasi
    static void Main()
    {
        int[] A = { 5, 7, 11, 23, 37, 45 };     // ** dizimiz sirali da olabilir, olmayabilir de. **
        int bas, son = A.Length - 1, orta, key; // ** fakat algoritma icin sirali olmasi gerekli  **
        bool durum = true;

        Array.Sort(A); // diziyi, kucukten buyuge dogru siraliyoruz.
                       // Baslangicta dizinin tamamini ele aliyoruz. o yuzden;
                       //bas = 0;              dizinin ilk indisini atiyoruz. yani 0. indis
                       //son = A.Length - 1;   dizinin son indisi

        Console.WriteLine("Aranicak degeri girin: ");
        key = int.Parse(Console.ReadLine());
        // for dongusu ile yaptigimizdan, artis aritmetik degil logaritmiktir;
        for (bas = 0; bas <= son;)   // bu yuzden artis degeri yazmadik.
        {                            // sadece durum belirttik.
            orta = (bas + son) / 2; // ortanca elemani buluyoruz.
            if (A[orta] == key)     // ortanca eleman, aranan elemana esitse
            {
                Console.WriteLine("Aranan deger bulundu! {0}. indistedir.", orta);
                durum = false; // 40. satirdaki if bloguna girmeyecek.
                break;
            }
            else if (A[orta] < key) // ortanca eleman, aranandan kucukse;
            {                       // aranan eleman daha buyuk olacaginden, dizinin sagina dogru gidilir.
                bas = orta + 1;     // baslangici ortanin bir ilerisine alarak, araligi saga kaydiriyoruz. son degiskeni SABIT...
                Console.WriteLine("{0} < {1} Daha buyuk sayilara bakiliyor...", A[orta], key);
            }
            else if (A[orta] > key) // ortanca eleman, aranandan buyukse;
            {
                son = orta - 1;     // sonuncu elemani, ortanin bir gerisine alarak araligi sola kaydiriyoruz. bas degiskeni SABIT...
                Console.WriteLine("{0} > {1} Daha kucuk sayilara bakiliyor...", A[orta], key);
            }
        }

        if (durum) // aranan deger bulunamadiysa, default degeri true olan durumdan; bu kod blogu isler.
            Console.WriteLine("Aranan deger bulunamamistir.");

        Console.ReadKey();
    }
}