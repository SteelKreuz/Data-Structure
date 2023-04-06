using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var s = new StackA();
            s.Push("one");
            s.Push("two");
            s.Push("three");
            s.Push("four");
            s.Push("five");

            Console.WriteLine("Boyut = " + s.Length + ", Boş mu = " + s.IsEmpty);

            var res = s.Pop();
            Console.WriteLine("Değer = " + res + ", Boyut = " + s.Length + ", Boş mu = " + s.IsEmpty);
            res = s.Pop();
            Console.WriteLine("Değer = " + res + ", Boyut = " + s.Length + ", Boş mu = " + s.IsEmpty);
            res = s.Pop();
            Console.WriteLine("Değer = " + res + ", Boyut = " + s.Length + ", Boş mu = " + s.IsEmpty);
            res = s.Pop();
            Console.WriteLine("Değer = " + res + ", Boyut = " + s.Length + ", Boş mu = " + s.IsEmpty);
            res = s.Pop();
            Console.WriteLine("Değer = " + res + ", Boyut = " + s.Length + ", Boş mu = " + s.IsEmpty);

            res = s.Pop();           

            s.Push("six");
            Console.WriteLine("Boyut = " + s.Length + ", Boş mu = " + s.IsEmpty);
            Console.WriteLine("Top = " + s.Peek());
            Console.ReadKey();
            

            /*
            var s = new StackL();
            s.Push("one");
            s.Push("two");
            s.Push("three");
            s.Push("four");
            s.Push("five");

            Console.WriteLine("Boyut = " + s.Length + ", Boş mu = " + s.IsEmpty);           
            Console.ReadKey();
            */
        }
    }
}
