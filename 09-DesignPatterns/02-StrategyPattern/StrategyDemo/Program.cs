using System;

namespace StrategyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var currentBase = "N";

            if(currentBase == "N")
            {
                Console.WriteLine("N - Open A C G T");
                Console.WriteLine("Wait 1 second");
                Console.WriteLine("N - Close A C G T");
                return;
            }

            if(currentBase == "M")
            {
                Console.WriteLine("M - Open A C");
                Console.WriteLine("Wait 1 second");
                Console.WriteLine("M - Close A C");
                return;
            }

            if(currentBase == "K")
            {
                Console.WriteLine("K - Open G T");
                Console.WriteLine("Wait 1 second");
                Console.WriteLine("K - Close G T");
            }






            MixedBase mixedBase = null;
            switch(currentBase)
            {
                case "N":
                    mixedBase = new MixedBaseN();
                    break;
                case "M":
                    mixedBase = new MixedBaseM();
                    break;
                case "K":
                    mixedBase = new MixedBaseK();
                    break;
            }

            mixedBase.Mix();
        }
    }
}
