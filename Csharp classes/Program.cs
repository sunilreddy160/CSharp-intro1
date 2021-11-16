using System;

namespace Csharp_classes
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Hello World!");
            customer o = new customer("sunil");

            Console.WriteLine(o.name);
            customer.print();
            customer.print1();
            Console.WriteLine("Hello World!");
        }
         public class customer
        {
            public string name;
            public customer(string name)
            {
                this.name = name;

            }
            public static void print()
            {
                Console.WriteLine("hello world");
            }
            public static void print1()
            {
                Console.WriteLine("hello");
            }
        }
    }
}
