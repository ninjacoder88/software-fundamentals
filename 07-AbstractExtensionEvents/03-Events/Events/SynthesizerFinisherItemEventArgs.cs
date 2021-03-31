using System;

namespace Events
{
    public class SynthesizerFinishedItemEventArgs : EventArgs
    {
        public string LogText {get;set;}
    }
}