using System;
using System.Linq;

namespace UnitTestingWithDI
{
    public class Processor
    {
        public Processor(IRepository repository, IOutputProxy outputProxy, ICsvParser csvParser)
        {
            _repository = repository;
            _outputProxy = outputProxy;
            _csvParser = csvParser;
        }

        public void Process(string filePath, string delimiter)
        {
            var csvMfgItems = _csvParser.Parse(filePath, delimiter);

            if (csvMfgItems == null)
                throw new Exception("No items returned from csv");

            var csvMfgItemList = csvMfgItems.ToList();

            string mfgItemIds = string.Join(",", csvMfgItemList.Select(x => x.MfgItemId));

            var mfgItemBarcodes = _repository.Load(mfgItemIds);

            if (mfgItemBarcodes == null)
                throw new Exception("No data found for mfgitems");

            var mfgItemBarcodeList = mfgItemBarcodes.ToList();

            var results =
                from cmi in csvMfgItemList
                join mb in mfgItemBarcodeList on cmi.MfgItemId equals mb.MfgItemId
                select new {cmi.MfgItemId, cmi.ReferenceNumber, mb.Barcode};

            foreach (var mfgItemBarcode in results.ToList())
            {
                _outputProxy.WriteLine($"{mfgItemBarcode.MfgItemId},{mfgItemBarcode.ReferenceNumber},{mfgItemBarcode.Barcode}");
            }
        }

        private readonly ICsvParser _csvParser;
        private readonly IOutputProxy _outputProxy;
        private readonly IRepository _repository;
    }
}