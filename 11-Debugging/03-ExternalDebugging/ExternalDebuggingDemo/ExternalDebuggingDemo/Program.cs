using System;
using Demo.Common;
using ExternalProject;

namespace ExternalDebuggingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var processor = new Processor(new Logger());
            processor.Process(@"C:\code\software-fundamentals\11-Debugging\data\data3.csv", 5);
            Console.ReadLine();
        }
    }
}
