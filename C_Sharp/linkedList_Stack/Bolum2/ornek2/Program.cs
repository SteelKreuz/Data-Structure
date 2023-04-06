/*
 *   Doubly Linked List (Cift Yonlu bagli liste): Sinif icinde tanimlanmis metodlar araciligiyla
 *   islem yapan bir baska versiyonudur.
 * 
 * *************************************************************************************************/

using System;

namespace DoublyLinkedList
{
    class Program
    {
        
        public static void Main()
        {
            LinkedList erisim = new LinkedList();

            erisim.Add("Bursa");
            erisim.Add("25");
            erisim.Add("False");
            erisim.Add("46.666");
            erisim.printForward();

            erisim.addFirst("Hello World");
            erisim.printForward();

            erisim.addLast("Bye Bye World");
            erisim.printForward();

            erisim.insertAfter("Bursa", "True");
            erisim.printForward();

            erisim.printBackwards();

            Console.ReadKey();
        }
    }
}