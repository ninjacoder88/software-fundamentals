using System;

namespace Conditionals
{
    public class IfStatements
    {
        public void Example()
        {
            Console.WriteLine("Start");

            int a = 2;
            int b = 3;
            int result = a + b;

            if(result == 5)
            {
                Console.WriteLine("5");
            }

            Console.WriteLine("Not 5");
        }
    }
}