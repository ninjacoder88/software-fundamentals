using System;

namespace Operators
{
    public class Incrementing
    {
        public void Example()
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