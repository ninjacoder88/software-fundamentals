using System;

namespace Arrays
{
    public static class ArrayExtensions
    {
        public static void Print(this int[] array)
        {
            foreach(var item in array)
                Console.WriteLine(item.ToString());
        }

        public static void Print(this string[] array)
        {
            foreach(var item in array)
                Console.WriteLine(item.ToString());
        }
    }
}