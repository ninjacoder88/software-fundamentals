using System;
using System.Threading;

namespace ThreadSleep
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(10);
            }
        }
    }
}
