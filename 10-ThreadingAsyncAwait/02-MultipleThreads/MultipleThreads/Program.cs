using System;

namespace MultipleThreads
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Threader t = new Threader();
            t.Go();
        }
    }
}
