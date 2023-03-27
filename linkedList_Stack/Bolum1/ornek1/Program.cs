using System;
namespace SinglyLinkedList
{
    public class Program
    {
        public static void printList(Node head) // Metod, parametre olarak bir nesne alacaktir.
        {
            var current = head; // Alinan nesne, baska bir nesneye atanir.
            while(current != null) // Donguye, "current" nesnesi, null degilse gir ve devam et.
            {                      // Bir baska deyisle; null olana kadar devam et.
                //Her dongude, current nesnesinde bulunan, main metodunda tanimladigimiz nesnelerin
                //Data degerlerini yazdiriyoruz.
                Console.Write(current.Data + " -> ");
                //Current nesnesine, her nesnenin isaret ettigi ( yani bagli oldugu )
                //bir diger nesneyi atiyoruz.
                current = current.Next;
            }
        }
        public static void Main(string[] args)
        {   // Burada her nesne, bir dugumdur.
            // Her dugumun kendi data ve next degeri vardir.
            // Nesneler olusturulurken, varsayilan olarak bizim buradan
            // gonderdigimiz degerler "Data" ozelliklerine atanir.
            var tom = new Node("Tom");
            var alexa = new Node("Alexa");
            var bruce = new Node("Bruce");
            var elena = new Node("Elena");

            // Dugumleri birbirine baglamak icin, isaretcilerine
            // bir sonraki nesneyi atiyoruz.
            tom.Next = alexa;
            alexa.Next = bruce;
            // Son dugumun (burada elena nesnesi oluyor) Next degeri null olur.
            bruce.Next = elena;

            printList(tom);

            Console.ReadKey();
        }
    }
}