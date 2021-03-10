using System;

namespace NamespacesClassesAndMore
{
    public interface IProcessor
    {
        string ProcessorType {get;}

        void ProcessFile(string file, int value);
    }

    public class AnotherProcessor : IProcessor
    {
        public string ProcessorType => throw new NotImplementedException();

        public void ProcessFile(string file, int value)
        {
            throw new NotImplementedException();
        }
    }

    public class Processor : IProcessor
    {
        public Processor(string name)
        {
            Name = name;
        }

        public string Name {get;}

        public string ProcessorType {get;set;}

        public void ProcessFile(string filePath, int value)
        {

        }

        public void Process(string data)
        {
            Console.WriteLine(Name);

            int i = 7;
            var j = 4;
            var k = "Some string";
            Console.WriteLine(i);

            const string SomeConstant = "Some Constant";

            j = 6;

            Calculate();
        }

        protected int Calculate()
        {
            return 0;
        }
    }
}