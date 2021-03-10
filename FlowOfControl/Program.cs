using System;

namespace FlowOfControl
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");

            int a = 1;
            int b = 1;

            Console.WriteLine(a);
            Console.WriteLine(a++);
            Console.WriteLine(a);
            Console.WriteLine(a++);
            Console.WriteLine(a);

            Console.WriteLine("---");

            Console.WriteLine(b);
            Console.WriteLine(++b);
            Console.WriteLine(b);
            Console.WriteLine(++b);
            Console.WriteLine(b);
            
            Console.WriteLine("End");
        }
    }
}
