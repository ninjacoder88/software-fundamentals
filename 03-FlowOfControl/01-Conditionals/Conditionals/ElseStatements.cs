using System;

namespace Conditionals
{
    public class ElseStatements
    {
        public void Example()
        {
            Console.WriteLine("Start");

            var result = 2 + 3;

            if(result == 5)
            {
                Console.WriteLine("5");
            }
            else
            {
                Console.WriteLine("Not 5");
            }

            Console.WriteLine("Everytime");

            Console.WriteLine("Not 5");
        }
    }
}