using System;

namespace ArrayStack
{
    class StackA
    {
        private int?[] stack; // Dizi ile olusturacagimiz yiginimiz.
        private int top;      // Yigindaki en tepede olan elemani gosterir. Sadece kacinci eleman oldugunu gosterir, degerini tutmaz!
        private int length;   // Yiginin uzunlugunu tutar. Fakat alternatif olarak (top + 1) zaten bu degeri verebiliyor...

        public StackA()
        {   // Siniftan nesne olusturuldugunda varsayilan degerler olusturulur.
            stack = new int?[7]; // Yiginimizin boyutu belirlenir.
            top = -1;           // Yigin bos iken herhangi bir elemani gostermeyeceginden negatif bir sayi atanir.
        }                       // Cunku 0 ve yukarisi, yiginin indis yani yigindaki elemanlarin sirasini gosterir. 

        public void Push(int? value) // Yigina eleman ekler.
        {
            top++; // Yigina her eleman eklendiginde, bir artar. Ne kadar eleman eklenmisse bir eksigini gosterir!!
                   // Misal, 5 eleman eklendiyse yigina; 0 1 2 3 4 diye artar. Yani 5 - 1 degerini tutar.
                   // Ve 4. indisteki eleman, yigindaki en ustte bulunan elemandir. top degiskeni, onun sirasini tutar.
            if (top < stack.Length) // Yigindaki eleman sayisi, yiginin kapasitesinden az mi diye kontrol ediliyor.
            {                       // az ise
                stack[top] = value; // Verilen degeri, yiginin en ustune yerlestirilir.
                length++;           // Yigin uzunlugu, her eleman eklenmede 1 artar.
            }
            else // eleman sayisi, dizinin kapasitesini asiyorsa, bu durum bildirilir.
                Console.WriteLine("Yigin doludur.");
        }

        // Alternatif Push() metodu:
        //public void push(int value)
        //{
        //    if (++top < stack.Length) // ++top: Once degeri arttirir ve yigin uzunluguyla karsilastirir
        //        stack[top] = value;   // Yukarda top degiskenin degeri zaten 1 arttirildi. Tekrar yapmaya gerek yok.
        //    else
        //        Console.WriteLine("Yigin doludur.");
        //}

        // Yigindan, en ustteki elemani ceker ve yiginden o elemani siler.
        public int? pop() // int? tanimi, tam sayi deger alabildigi gibi null deger de almasini saglar.
        {                 // Normalde string haric, diger veri tipleri null deger alamaz.
                          // Fakat bu tanimla almasini sagliyoruz. Bu tip degiskenlere "nullable" denir.
            if (top < 0)
            {
                Console.WriteLine("Yigin bostur.");
                return null; 
            }
            else
            {               
                top--;     // en ustteki elemani isaret eden, top degiskeninin degerini bir azaltiyoruz.
                length--;  // Length degiskeni de ayni sekilde.
                int? temp = stack[top + 1]; // top degiskeninin degeri 1 azaltildigindan, en ustteki elemana ulasmak icin top
                                            // degiskenin degerinin 1 fazlasini alarak, yigindaki isaret ettigi degere ulasip
                                            // o degeri bir degiskene aliyoruz/atiyoruz.
                stack[top + 1] = null; // en ustten alinan deger, yigindan siliniyor.
                return temp;           // 53. satirdaki deger geri donduruluyor.
            }
        }

        // Alternatif Pop Metodu:
        //public int? Pop()
        //{
        //    if(top < 0)
        //    {
        //        Console.WriteLine("Yigin Bostur.");
        //        return null;
        //    }
        //    else
        //    {
        //        int? temp = stack[top]; // Yigindaki en ustte olan elemani bir degiskene kopyaladik.
        //                                  
        //        stack[top--] = null;    // top--: once top degerini at, SONRA DEGERI AZALT demektir bu kod.
        //        length--;               // Yani en ustteki elemani sildik ve top degerini 1 azalttik.
        //        return temp;            // Geriye en ustteki elemani "temp" degiskeni ile geri donduruyoruz.
        //    }
        //}

        // Yiginin en ustteki elemanini sadece geri dondurur.
        // Pop'tan farki, elemani silmez. Sadece geri dondurur.
        public int? Peek()
        {
            return stack[top];
        }

        // Yigin bos mu degil mi diye kontrol eder top degiskeni ile.
        public bool IsEmpty
        {
            get { return top < 0; }
        }
    }
}