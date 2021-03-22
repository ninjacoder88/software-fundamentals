using System;

namespace ValueTypes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i = 7;
            Console.WriteLine(i);

            int j = 8;
            Console.WriteLine(j);

            decimal d = 7.4m;
            Console.WriteLine(d);

            string s = "this is a string";
            Console.WriteLine(s);

            i = j;
            j = 9;
            Console.WriteLine(i);
            Console.WriteLine(j);
        }
    }
}
