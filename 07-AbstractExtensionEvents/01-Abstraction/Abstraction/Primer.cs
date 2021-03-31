namespace Abstraction
{
    public class Primer : MfgItem
    {
        public void Do()
        {
            Sequence = "ATCTCACAGGACGCCTAATCGGCCG";
        }

        public override bool IsInternal()
        {
            return true;
        }
    }
}