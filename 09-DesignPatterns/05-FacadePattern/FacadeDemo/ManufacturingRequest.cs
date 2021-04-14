namespace FacadeDemo
{
    public class ManufacturingRequest
    {
        public ManufacturingRequest(BiosecurityScreener biosecurity, ManufacturabilityScreener manufacturability, CreditCheck creditCheck)
        {
            _biosecurity = biosecurity;
            _manufacturability = manufacturability;
        }

        public bool CanProcess(string sequence, string customer)
        {
            if(_biosecurity.IsThreat())
                return false;

            if(_manufacturability.ComplexityLimitReached())
                return false;

            if(!_creditCheck.HasGoodCredit())
                return false;

            return true;
        }

        private BiosecurityScreener _biosecurity;
        private ManufacturabilityScreener _manufacturability;
        private CreditCheck _creditCheck;
    }
}