using System;
using System.Collections.Generic;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            List<MfgItem> mfgItems = new List<MfgItem>();
            mfgItems.Add(new Primer { Sequence = "AAA", Name = "Primer 1", ProductId = 2 });
            mfgItems.Add(new Primer { Sequence = "AAC", Name = "Primer 2", ProductId = 2 });
            mfgItems.Add(new Primer { Sequence = "AAG", Name = "Primer 3", ProductId = 2 });
            mfgItems.Add(new Ultramer { Sequence = "GGA", Name = "Ultramer 1", ProductId = 1, Tm = 65 });
            mfgItems.Add(new Ultramer { Sequence = "GGC", Name = "Ultramer 2", ProductId = 1, Tm = 65 });
            mfgItems.Add(new Ultramer { Sequence = "GGG", Name = "Ultramer 3", ProductId = 1, Tm = 65 });

            SynthesizerManager manager = new SynthesizerManager();
            manager.Run(mfgItems);
        }
    }
}
