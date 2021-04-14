using System;
using System.Collections.Generic;

namespace FactoryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfMixedBaseCharacters = new List<char>{'N', 'N', 'K', 'M'};

            foreach(var item in listOfMixedBaseCharacters)
            {
                MixedBase mixedBase = null;
                switch(item)
                {
                    case 'N':
                        mixedBase = new MixedBaseN();
                        break;
                    case 'M':
                        mixedBase = new MixedBaseM();
                        break;
                    case 'K':
                        mixedBase = new MixedBaseK();
                        break;
                }

                mixedBase.Mix();
            }

            









            MixedBaseFactory factory = new MixedBaseFactory();

            foreach(var item in listOfMixedBaseCharacters)
            {
                var mixedBaseStrategy = factory.Provide(item);

                mixedBaseStrategy.Mix();
            }  
        }
    }
}
