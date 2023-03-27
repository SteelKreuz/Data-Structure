using System;

namespace SinglyLinkedList // Singly (Tek yonlu giden) Linked list (Bagli liste) tanimi:
{   // Bir dugum(ingilizcesi: node) sinifi olusturuyoruz.
    // Bu dugumlerin her biri, veri/veriler ve bir sonraki dugumun adresini tutacaktir.
    // Node sinifinda:
    // 1 tane verimizi tutacak Data ozelligimiz(bk: sinifin degiskeni),
    // 1 tane isaretcimiz (bk: pointer) olan, yani bir sonraki dugumu gosteren Next ozelligi,
    // 1 tane de constructor (bk: yapici metod) method tanimlanacaktir.
    public class Node 
    {
        public string Data;

        // Burada aslinda, bir nesne tanimlamasi yaptik. Bu "Next" nesnesi, bir nesne tutacaktir.
        // Bunu tir gibi dusunebiliriz. Arkasinda, otomobil tasiyan tirlar gibi. Ya da traktor gibi.
        // Motorlu bir tasit, baska bir motorlu tasiti tasiyor. 
        public Node Next;
                
        public Node(string data) // Burada yapici metod tanimlamasi yapiliyor. Bir string parametresi var!
        {                // Varsayilan olarak:
            Data = data; // Alinan parametreyi, sinifin ozelligine aktariyor.
            Next = null; // isaretcimiz null yapiliyor.
        }
        // Hepsi public olarak tanimlandi. Cunku disaridan hepsine erisilecektir.
    }
}
