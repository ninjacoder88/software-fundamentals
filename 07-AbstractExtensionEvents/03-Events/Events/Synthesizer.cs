using System;
using System.Collections.Generic;

namespace Events
{
    public class Synthesizer
    {
        public event EventHandler<SynthesizerFinishedItemEventArgs> MfgItemSynthsized;

        public void Synthesize(List<MfgItem> mfgItems)
        {
            foreach(var mfgItem in mfgItems)
            {
                string logText = $"{mfgItem.Name} is {mfgItem.CalculateSequenceLength()} bases long";
                OnMfgItemSynthesized(new SynthesizerFinishedItemEventArgs(){LogText = logText});
            }
        }

        protected virtual void OnMfgItemSynthesized(SynthesizerFinishedItemEventArgs eventArgs)
        {
            EventHandler<SynthesizerFinishedItemEventArgs> handler = MfgItemSynthsized;
            if (handler != null)
                handler(this, eventArgs);
        }
    }
}