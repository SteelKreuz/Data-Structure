using System;

namespace DoublyLinkedList
{         // Cift yonlu bagli liste
    class Program
    {
        public static void printForward(Node head)
        {                  // ileriye dogru yazdirir
            var current = head;
            while(current != null)
            {
                if(current.Next != null)
                {
                    Console.Write(current.Data + " -> ");
                    current = current.Next;
                }
                else
                {
                    Console.WriteLine(current.Data);
                    current = current.Next;
                }
            }
        }
        public static void printBackwards(Node tail)
        {                  // geriye dogru yazdirir
            var current = tail;
            while(current != null)
            {
                if (current.Prev != null)
                {
                    Console.Write(current.Data + " -> ");
                    current = current.Prev;
                }
                else
                {
                    Console.WriteLine(current.Data);
                    current = current.Prev;
                }
            }
        }
        public static void Main()
        {
            var tom = new Node("Tom");
            var alexa = new Node("Alexa");
            var bruce = new Node("Bruce");
            var elena = new Node("Elena");

            tom.Next = alexa;
            alexa.Next = bruce;
            bruce.Next = elena;

            elena.Prev = bruce;
            bruce.Prev = alexa;
            alexa.Prev = tom;

            printForward(tom);
            printBackwards(elena);

            Console.ReadKey();
        }
    }
}