using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class LinkedList
    {
        public Node Head { get; private set; } // listenin başı
        public Node Tail { get; private set; } // listenin sonu 
        public int Length { get; private set; } // eleman sayısı       
        public Node Append(string data) // listenin sonuna eleman ekleme
        {
            Node n = new Node(data); // listeye eklenecek düğüm oluştur
            if (Head == null) // liste boşsa
            {
                Head = n; // head yeni düğüm olsun

                //Tail = n; //ikinci yöntem için

            }
            else // eğer listede eleman varsa son elemana kadar listeyi incele ve yeni eleman ekle
            {
                Node current = Head; // current adında bir düğüm oluştur ve listenin başını ona ata
                while (current.Next != null) // current düğümünün işaretçisi boş değilse
                {
                    current = current.Next; // current'ı ilerlet
                } // döngüden sonra current son düğüm olur, sonra onun işaretçisine yeni düğümü atanır
                current.Next = n;

                /* ikinci yöntem için
                Tail.Next = n;
                Tail = n;
                */
            }
            Length++;
            return n;
        }

        internal void Remove(int v)
        {
            throw new NotImplementedException();
        }

        public Node Prepend(string data) // listenin başına eleman ekleme
        {
            Node n = new Node(data);
            if (Head == null)
            {
                Head = n;
                Tail = n;
            }
            else
            {
                n.Next = Head;
                Head = n;
            }
            Length++;
            return n;
        }
        public Node Find(string data)
        {
            Node current = Head;
            while (current != null)
            {
                if (current.Data == data)
                {
                    return current;
                }
                current = current.Next;
            }
            return null;
        }
        public void PrintList() // elemanları yazdırma
        {
            if (Head == null)
                Console.WriteLine("Liste boş"); 
            else
            {
                var current = Head; 
                while (current != null)
                {
                    Console.Write(current.Data + "->");
                    current = current.Next; 
                }
            }
        }
    }
}
