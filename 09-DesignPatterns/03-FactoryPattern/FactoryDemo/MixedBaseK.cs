using System;

namespace FactoryDemo
{
    public class MixedBaseK : MixedBase
    {
        public override void Mix()
        {
            Console.WriteLine("K - Open G T");
            Console.WriteLine("Wait 1 second");
            Console.WriteLine("K - Close G T");
        }
    }
}