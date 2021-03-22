using System;

namespace Arrays
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] integerArrary = new int[4]; //integer array of size 4
            string[] stringArray = new string[6]; //string array of size 6

            integerArrary[0] = 1; //arrays are 0 based, meaning the first position is position 0
            integerArrary[3] = 4; //given arrays are 0 based, the last value is the array length - 1

            integerArrary.Print();

            stringArray[0] = "1";
            stringArray.Print();
        }
    }
}
