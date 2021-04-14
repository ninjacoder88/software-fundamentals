using System;

namespace FactoryDemo
{
    public class MixedBaseM : MixedBase
    {
        public override void Mix()
        {
            Console.WriteLine("M - Open A C");
            Console.WriteLine("Wait 1 second");
            Console.WriteLine("M - Close A C");
        }
    }
}