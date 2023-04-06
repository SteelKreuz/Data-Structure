using System;

namespace HelloWorld
{   
    class Program
    {
        
        public static void Main()
        {
            var vagonBir = new Dugum("1. vagon");
            var vagonIki = new Dugum("2. vagon");
            var vagonUc = new Dugum("3. vagon");
            var vagonDort = new Dugum("4. vagon");

            Dugum erisim = new Dugum("Erisim nesnesi");

            erisim.Yazdir(vagonBir, vagonIki, vagonUc, vagonDort);
            // Verilen siraya gore yazdirir.
            Console.ReadKey();
        }
    }
}