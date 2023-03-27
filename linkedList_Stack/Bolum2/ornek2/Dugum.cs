using System;

namespace DoublyLinkedList
{
    class Node
    {
        public string Data { get; set; } 
        public Node Next { get; set; }
        public Node Prev { get; set; }

        public Node(string data, Node next = null, Node prev = null)
        {                       // next ve prev parametreleri opsiyoneldir.
            Data = data;        // varsayilan olarak null degeri alirlar.
            Next = next;
            Prev = prev;
        }
    }

    class LinkedList
    {   // Listedeki dugumler, ilk eleman (dugum) vasitasi ile tutulacaktir.
        private Node Head; // ilk eleman Head nesnesinde tutulur.
        // Listedeki elemanlarin sonuncusu, Tail (kuyruk) nesnesinde tutulacaktir.
        private Node Tail;

        // Listedeki butun dugumleri, ileri dogru yazdirir.
        public void printForward()
        {
            Console.WriteLine("Ileri dogru yazdirma islemi basliyor:\n-------------------------------");
            var current = Head; // ilk eleman, gecici nesneye atilip, bir nevi kopyasi alinir.
            while(current != null) // current nesnesi bos degilse devam et
            {
                if (current.Next != null) // current nesnesinin tuttugu dugumun, son eleman olup,
                {                         // olmadigi kontrol edilir. Degilse:
                    Console.Write(current.Data + " -> "); // verisi yazdirilir.
                    current = current.Next; // bir sonraki dugume gecilir.
                }
                else // Son eleman ise
                {   // bu sekilde yazdirilir.
                    Console.WriteLine(current.Data + "\n");
                    current = current.Next;
                }
            }
        }
        
        public void printBackwards()
        {
            Console.WriteLine("Geriye dogru yazdirma islemi basliyor:\n-------------------------------");
            var current = Tail; // son dugumden baslatilir.
            while(current != null)
            {
                if (current.Prev != null)
                {
                    Console.Write(current.Data + " -> ");
                    current = current.Prev;
                }
                else
                {
                    Console.WriteLine(current.Data + "\n");
                    current = current.Prev;
                }
            }
        }
        // Listeye dugum ekler.
        public void Add(string data)
        {
            if(Head == null) // ilk dugum yoksa, liste bostur.
            {                            // O yuzden Head nesnesi, sadece tanimlanmistir. Olusturulmamistir.
                Head = new Node(data);       // Burada nesnemizi olusturup, varsayilan degerler ataniyor.
                Tail = Head;                 // Hem baslangic hem son eleman oluyor.
            }
            else  // ilk dugum varsa, listede en az 1 eleman vardir.
            {
                Node toAdd = new Node(data); // ornek nesne olusturulur ve veri atanir.
                // Bagli listelerde, istenen elemana gitmek icin o elemana kadar olan butun elemanlar
                // uzerinden gecilir. 
                var current = Head;  // Bu yuzden listenin ilk elemanini aliyoruz. 
                while(current != null)
                { // Siradan eleman eklicegimiz icin son elemana kadar gidilir.
                    if(current.Next == null) // son eleman bulunursa
                    {
                        current.Next = toAdd; // son elemanin, isaretcisine, eklenicek eleman verilir.
                        toAdd.Prev = current; // Dongude, o anki son elemani, eklicegimiz elemani geriye dogru bagliyoruz.
                        Tail = toAdd;         // Eklenen eleman, son eleman olur.
                        current = null; // ve islem biter. current null yapilir ve dongu biter.
                    }
                    else // son eleman bulunana kadar, elemanlar uzerinden gecilir.
                    {
                        current = current.Next;
                    }

                }
            }
        
        }

        public void addFirst(string data) // push() diye de adlandirilabilir.
        {   // Listenin basina dugum ekleyen metod.
            if (Head == null) // liste bos mu diye kontrol ediliyor.
            {                 // bos ise gerekli islemler yapiliyor.
                Head = new Node(data);
                Tail = Head;
            }
            else // Degilse
            {    
                Node toAdd = new Node(data, Head); // Ornek bir dugum olusturulur. 
                Head.Prev = toAdd;       // ilk elemani, basa ekleyecegimiz elemana baglariz.
                Head = toAdd;            // Ve listenin ilk dugumu, artik bu dugum olur.
            }
        }

        public void addLast(string data) // bir diger adi append()
        {   // Listenin sonuna dugum ekleyen metod.
            if(Head == null)
            {
                Head = new Node(data);
                Tail = Head;
            }
            else
            {                     
                Node current = Head;        // ilk dugum kopyalanir.
                while(current.Next != null) // Son dugum bulunur
                {
                    current = current.Next;
                }
                Node toAdd = new Node(data, null, current); // gerekli dugum tanimi yapilir.
                Tail = toAdd;               // Son eleman, ekleyecegimiz eleman olucak artik.
                current.Next = toAdd;       // Son dugumun isaretcisi, eklenmek istenen dugume baglanir.
            }
        }

        public void insertAfter(string Odata, string data)
        {   // Listenin herhangi arasina dugum ekleyen metod.
            var current = Head;
            while(current != null)
            {   // Her dongude, listedeki dugumlerin Datasi, alinan data bilgisiyle karsilastirilir.
                if (current.Data == Odata) // Eger esitse
                {   // Ekleyecegimiz dugum olusturulur.
                    Node toAdd = new Node(data, current.Next, current);
                    current.Next.Prev = toAdd; // **1 
                    current.Next = toAdd;
                    return; // Metodu sonlandirir.
                }
                else
                    current = current.Next;
            }
        }  
    }
}
/* **1: insertAfter metodu, herhangi bir iki dugum arasina dugum ekledigi icin
 *  soz konusu satirda: current.Next.Prev komutu sunu yapar. Ornek bir liste:
 * 
 *      "elma", "armut", "kiraz" --> armut ile kiraz arasina cilek eklicez diyelim.
 *      current = "armut" olsun, ->> current.Next = "kiraz", ->> current.Next.Prev = Current olur.
 *      Bu ikisi arasina da "cilek" karakterini yerlestiricez.
 *      
 *      current.Next.Prev eger Cilek olursa ve
 *      current.Next eger Cilek olursa
 *      
 *      Kiraz ile armut arasina cilegi yerlestirmis oluruz. Bu komut tam olarak bunu yapıyor...
 ****************************************************************************************************/