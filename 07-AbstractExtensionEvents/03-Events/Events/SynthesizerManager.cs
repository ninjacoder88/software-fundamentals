using System;
using System.Collections.Generic;

namespace Events
{
    public class SynthesizerManager
    {
        public void Run(List<MfgItem> mfgItems)
        {
            Synthesizer synthesizer = new Synthesizer();
            synthesizer.MfgItemSynthsized += SynthesizerFinishedItem;
            synthesizer.Synthesize(mfgItems);  
        }

        private void SynthesizerFinishedItem(object sender, SynthesizerFinishedItemEventArgs e)
        {
            Console.WriteLine(e.LogText);
        }
    }
}