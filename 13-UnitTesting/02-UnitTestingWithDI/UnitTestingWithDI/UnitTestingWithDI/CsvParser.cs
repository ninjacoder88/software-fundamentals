using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestingWithDI
{
    public interface ICsvParser
    {
        IEnumerable<CsvMfgItem> Parse(string filePath, string delimiter);
    }

    public class CsvParser : ICsvParser
    {
        public CsvParser(IFile fileProxy)
        {
            _fileProxy = fileProxy;
        }

        public IEnumerable<CsvMfgItem> Parse(string filePath, string delimiter)
        {
            var fileLines = _fileProxy.ReadAllLines(filePath);

            if (fileLines == null)
                throw new Exception("No file lines exists");

            var fileLineList = fileLines.ToList();
            
            foreach (var fileLine in fileLineList)
            {
                var csvMfgItem = ParseFileLine(fileLine, delimiter);
                
                if(csvMfgItem == null)
                    continue;

                yield return csvMfgItem;
            }
        }

        private CsvMfgItem ParseFileLine(string fileLine, string delimiter)
        {
            string[] splitFileLine = fileLine.Split(new[] { delimiter }, StringSplitOptions.None);

            if (!int.TryParse(splitFileLine[0], out int mfgItemId))
                return null;

            if (!int.TryParse(splitFileLine[1], out int referenceNumber))
                return null;

            return new CsvMfgItem
                                {
                                    MfgItemId = mfgItemId,
                                    ReferenceNumber = referenceNumber
                                };
        }

        private readonly IFile _fileProxy;
    }
}