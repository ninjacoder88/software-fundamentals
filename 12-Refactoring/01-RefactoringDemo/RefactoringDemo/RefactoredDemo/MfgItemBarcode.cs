namespace RefactoredDemo
{
    public class MfgItemBarcode
    {
        public int MfgItemId { get; set; }

        public int Barcode { get; set; }

        public override string ToString()
        {
            return $"MfgItemId: {MfgItemId}; Barcode: {Barcode}";
        }
    }
}