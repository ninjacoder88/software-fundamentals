using System;

namespace Conditionals
{
    public class SwitchStatements
    {
        public void Example()
        {
            int a = 1;
            int b = 2;

            int result = a + b;
            switch(result)
            {
                case 3:
                    Console.WriteLine("3");
                    break;
                case 4:
                    Console.WriteLine("4");
                    break;
                case 5:
                    Console.WriteLine("5");
                    break;
                default:
                    Console.WriteLine("Not Handled");
                    break;
            }
        }
    }
}