using System;
using System.Threading.Tasks;

namespace AwaitingTasks
{
    public class AsyncRunner
    {
        public async Task RunAsync()
        {
            Console.WriteLine("Start some work");
            await Task.Factory.StartNew(() => DoSomething("A"));
            Console.WriteLine("Do some work");
	        await Task.Factory.StartNew(() => DoSomething("B"));
            Console.WriteLine("Do more work");
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