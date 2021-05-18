using System;

namespace RefactoredDemo
{
    public interface IOutputProxy
    {
        void WriteLine(string value);
    }

    public class OutputProxy : IOutputProxy
    {
        public void WriteLine(string value)
        {
            Console.WriteLine(value);
        }
    }
}