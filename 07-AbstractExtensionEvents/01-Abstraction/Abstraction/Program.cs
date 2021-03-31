using System;
using System.Collections.Generic;

namespace Abstraction
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Primer> primers = new List<Primer>();
            primers.Add(new Primer { Sequence = "AAA", Name = "Primer 1", ProductId = 2 });
            primers.Add(new Primer { Sequence = "AAC", Name = "Primer 2", ProductId = 2 });
            primers.Add(new Primer { Sequence = "AAG", Name = "Primer 3", ProductId = 2 });

            List<Ultramer> ultramers = new List<Ultramer>();
            ultramers.Add(new Ultramer { Sequence = "GGA", Name = "Ultramer 1", ProductId = 1, Tm = 65 });
            ultramers.Add(new Ultramer { Sequence = "GGC", Name = "Ultramer 2", ProductId = 1, Tm = 65 });
            ultramers.Add(new Ultramer { Sequence = "GGG", Name = "Ultramer 3", ProductId = 1, Tm = 65 });

            List<MfgItem> mfgItems = new List<MfgItem>();
            mfgItems.Add(new Ultramer { Sequence = "GGA", Name = "Ultramer 1", ProductId = 1, Tm = 65 });
            mfgItems.Add(new Primer { Sequence = "AAA", Name = "Primer 1", ProductId = 2 });
            mfgItems.Add(new Ultramer { Sequence = "GGC", Name = "Ultramer 2", ProductId = 1, Tm = 65 });
            mfgItems.Add(new Primer { Sequence = "AAC", Name = "Primer 2", ProductId = 2 });
            mfgItems.Add(new Ultramer { Sequence = "GGG", Name = "Ultramer 3", ProductId = 1, Tm = 65 });
            mfgItems.Add(new Primer { Sequence = "AAG", Name = "Primer 3", ProductId = 2 });
            
            Synthesizer s = new Synthesizer();
            // s.SynthesizePrimers(primers);
            // s.SynthesizeUltramers(ultramers);
            s.Synthesize(mfgItems);
        }
    }
}
