using System;
using System.Collections.Generic;

namespace Abstraction
{
    public class Synthesizer
    {
        public void SynthesizeUltramers(List<Ultramer> ultramers)
        {
            foreach(var ultramer in ultramers)
            {
                Console.WriteLine(ultramer.Name);
            }
        }

        public void SynthesizePrimers(List<Primer> primers)
        {
            foreach(var primer in primers)
            {
                Console.WriteLine(primer.Name);
            }
        }

        public void Synthesize(List<MfgItem> mfgItems)
        {
            foreach(var mfgItem in mfgItems)
            {
                Console.WriteLine($"{mfgItem.Name} is {mfgItem.CalculateSequenceLength()} bases long and is internal = {mfgItem.IsInternal()}");
            }
        }
    }
}