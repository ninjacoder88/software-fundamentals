using System;
using System.Threading.Tasks;

namespace AwaitingTasks
{
    public class Runner
    {
        public void Run()
        {
            Task t1 = Task.Factory.StartNew(() => DoSomething("A"));
            Task t2 = Task.Factory.StartNew(() => DoSomething("B"));
            Task.WaitAll(t1, t2);
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