using System;

namespace ValueTypesVsReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // int i = 7;
            // int j = 8;
            // i = j;
            // j = 9;

            var i = new Demo{Value = "7"};
            var j = new Demo{Value = "8"};

            i = j;
            j.Value = "9";

            Console.WriteLine("i: " + i.Value); //8
            Console.WriteLine("j: " + j.Value); //9
        }
    }
}
