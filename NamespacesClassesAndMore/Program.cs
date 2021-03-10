using System;
using System.Collections.Generic;

namespace NamespacesClassesAndMore
{
    class Program
    {
        static void Main(string[] args)
        {
            IProcessor processor = new Processor("");
            IProcessor anotherProcessor = new AnotherProcessor();

            List<IProcessor> processors = new List<IProcessor>();
            processors.Add(processor);
            processors.Add(anotherProcessor);

            foreach(var p in processors)
            {
                //p.ProcessFile();
            }
        }
    }
}
