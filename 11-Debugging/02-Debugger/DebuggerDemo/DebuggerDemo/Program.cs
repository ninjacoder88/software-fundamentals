using System;

namespace DebuggerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            new Processor(new Logger()).Process(@"C:\code\software-fundamentals\11-Debugging\data\data.csv", 5);
            Console.ReadLine();
        }
    }
}
