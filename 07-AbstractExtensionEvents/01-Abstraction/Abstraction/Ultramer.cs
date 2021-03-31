namespace Abstraction
{
    public class Ultramer : MfgItem
    {
        public int Tm {get;set;}

        public override bool IsInternal()
        {
            if(Name.Contains("1"))
                return true;
            return false;
        }
    }
}