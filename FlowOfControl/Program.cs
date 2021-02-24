using System;

namespace FlowOfControl
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");

            var a = 2;
            var b = 2;
            var r = a + b;

            if(r == 4)
            {
                Console.WriteLine("4");
            }
        }
    }
}
