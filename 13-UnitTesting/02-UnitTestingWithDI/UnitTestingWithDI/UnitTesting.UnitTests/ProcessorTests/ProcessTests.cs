using System.Collections.Generic;
using AutoFixture;
using NSubstitute;
using NUnit.Framework;
using UnitTestingWithDI;

namespace UnitTesting.UnitTests.ProcessorTests
{
    [TestFixture]
    public class ProcessTests
    {
        [SetUp]
        public void SetUp()
        {
            _repository = Substitute.For<IRepository>();
            _outputProxy = Substitute.For<IOutputProxy>();
            _csvParser = Substitute.For<ICsvParser>();
            _fixture = new Fixture();
        }
        
        [Test]
        public void CriticalPath()
        {
            //SETUP
            var filePath = _fixture.Create<string>();
            var delimiter = _fixture.Create<string>();
            _csvParser.Parse(filePath, delimiter).Returns(new List<CsvMfgItem>()
                                                              {
                                                                  new CsvMfgItem(){MfgItemId = 100, ReferenceNumber = 1000},
                                                                  new CsvMfgItem(){MfgItemId = 200, ReferenceNumber = 2000},
                                                              });
            _repository.Load("100,200").Returns(new List<MfgItemBarcode>
                                                    {
                                                        new MfgItemBarcode() {MfgItemId = 100, Barcode = 111111},
                                                        new MfgItemBarcode() {MfgItemId = 200, Barcode = 222222},
                                                    });
            var SUT = new Processor(_repository, _outputProxy, _csvParser);

            //TEST
            SUT.Process(filePath, delimiter);
            
            //VALIDATE
            _outputProxy.Received(1).WriteLine("100,1000,111111");
            _outputProxy.Received(1).WriteLine("200,2000,222222");
        }

        private IRepository _repository;
        private IOutputProxy _outputProxy;
        private ICsvParser _csvParser;
        private Fixture _fixture;
    }
}