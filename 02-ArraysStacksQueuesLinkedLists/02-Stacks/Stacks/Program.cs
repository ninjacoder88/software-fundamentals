using System;
using System.Collections.Generic;

namespace Stacks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Stack<string> strStack = new Stack<string>();
            strStack.Push("A");
            strStack.Push("B");
            strStack.Pop();
            strStack.Push("C");
            strStack.Pop();
            strStack.Pop();

            strStack.Print();

            Stack<int> intStack = new Stack<int>();
            intStack.Push(1);
            intStack.Push(2);
            intStack.Pop();
            intStack.Push(3);
            intStack.Pop();
            intStack.Pop();

            intStack.Print();

        }
    }
}
