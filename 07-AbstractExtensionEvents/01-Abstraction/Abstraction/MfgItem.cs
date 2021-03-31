namespace Abstraction
{
    public abstract class MfgItem
    {
        public string Sequence {get;set;}

        public string Name {get;set;}

        public int ProductId {get;set;}

        public int CalculateSequenceLength()
        {
            return Sequence.Length;
        }

        public abstract bool IsInternal();
    }
}