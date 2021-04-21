using System;
using System.Threading.Tasks;

namespace TaskDemo
{
    public class Runner
    {
        public void Run()
        {
            Console.WriteLine("Work on something");
            Task.Factory.StartNew(() => DoSomething("A"));
            Console.WriteLine("Work on something else");
	        Task.Factory.StartNew(() => DoSomething("B"));
            Console.WriteLine("Done");
        }

        private void DoSomething(string threadName)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{threadName} - {i}");
            }
        }
    }
}