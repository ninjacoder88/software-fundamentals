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
        public void TestName()
        {
            //SETUP
            var filePath = _fixture.Create<string>();
            var delimiter = _fixture.Create<string>();
            var SUT = new Processor(_repository, _outputProxy, _csvParser);

            //TEST
            SUT.Process(filePath, delimiter);
            
            //VALIDATE
        }

        private IRepository _repository;
        private IOutputProxy _outputProxy;
        private ICsvParser _csvParser;
        private Fixture _fixture;
    }
}