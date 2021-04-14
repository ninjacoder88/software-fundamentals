using System;

namespace FactoryDemo
{
    public class MixedBaseN : MixedBase
    {
        public override void Mix()
        {
            Console.WriteLine("N - Open A C G T");
            Console.WriteLine("Wait 1 second");
            Console.WriteLine("N - Close A C G T");
        }
    }
}