using System;
using System.Threading;

namespace MultipleThreads
{
    public class Threader
    {
        public void Go()
        {
            Thread t1 = new Thread(new ThreadStart(DoWork));
            Thread t2 = new Thread(new ThreadStart(DoWork));
            t1.Start();
            t2.Start();
        }

        private void DoWork()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}