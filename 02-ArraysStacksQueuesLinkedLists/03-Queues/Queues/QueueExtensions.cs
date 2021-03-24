using System;
using System.Collections.Generic;

namespace Queues
{
    public static class QueueExtensions
    {
        public static void Print<T>(this Queue<T> queue)
        {
            var array = queue.ToArray();

            foreach(var item in array)
                Console.Write(item.ToString() + "\t");
        }
    }
}