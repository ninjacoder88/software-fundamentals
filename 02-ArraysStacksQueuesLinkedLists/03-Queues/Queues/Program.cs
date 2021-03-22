using System;

namespace Queues
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("A");
            queue.Enqueue("B");
            queue.Dequeue();
            queue.Enqueue("C");
            queue.Dequeue();
            queue.Dequeue();

            queue.Print();
        }
    }
}
