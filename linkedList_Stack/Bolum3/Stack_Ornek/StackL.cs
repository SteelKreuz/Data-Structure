using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class StackL // Yığın bağlı liste uygulaması
    {
        private LinkedList _list; // bir bagli liste olusturur.
        public int Length { get { return _list.Length; } } // bagli listedeki eleman sayısını geri döndürür

        public StackL() // Yapıcı
        {
            _list = new LinkedList(); // bagli liste örneği oluştur
        }

        public void Push(string val) // Yığına eleman ekleme
        {
            _list.Prepend(val);      // Yiginin basina prepend() metodu ile "val" degiskenindeki degeri ekler.
                                     // Basina eklenir cunku Yiginlarda LAST IN FIRST OUT (Son giren ilk cikar)
                                     // mantigi vardir. En son eklenen eleman, yiginin 1. elemani olur
                                     // En basta eklenen eleman en sonuncu eleman olur.
        }

        public string Pop() // Yığından eleman çıkarma, yığın boş ya da dolu olabilir
        {
            if (_list.Head == null) // Yığın boşsa
            {
                Console.WriteLine("Yığın boştur");
                return null;
            }
            else // listedeki ilk elemanı silmeden önce onun verisini bir değişkende tut
            {
                var res = _list.Head.Data; // Listedeki ilk eleman "head" nesnesinde tutulur. Ve onun data'si "res" nesnesine atilir.
                _list.Remove(0);
                return res; // yigindaki ilk eleman "res" te tutulur. Dolayisi ile ilk elemani geri dondurur.
            }
        }

        public string Peek() // yiginin ilk elemanini geri dondurur.
        {
            return _list.Head.Data;
        }

        public bool IsEmpty // Yigin bos mu degil mi diye kontrol eder. Ve Sonucu true veya false olarak dondurur.
        {
            get { return _list.Length <= 0; }
        }
           
    }
}
