using System.Linq;
using AutoFixture;
using NSubstitute;
using NUnit.Framework;
using UnitTestingWithDI;

namespace UnitTesting.UnitTests.CsvParserTests
{
    [TestFixture]
    public class ParseTests
    {
        [SetUp]
        public void SetUp()
        {
            _file = new FileProxy();
            _fixture = new Fixture();
        }
        
        [Test]
        public void TestName()
        {
            //SETUP
            var filePath = _fixture.Create<string>();
            var delimiter = "|";
            var SUT = new CsvParser(_file);

            //TEST
            var results = SUT.Parse(filePath, delimiter);

            //VALIDATE
        }

        private IFile _file;
        private Fixture _fixture;
    }
}