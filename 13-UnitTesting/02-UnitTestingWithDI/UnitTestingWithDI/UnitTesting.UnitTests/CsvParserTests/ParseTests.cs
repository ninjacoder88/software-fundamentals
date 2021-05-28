using System;
using System.Data;
using System.Linq;
using AutoFixture;
using NSubstitute;
using NSubstitute.ExceptionExtensions;
using NSubstitute.ReturnsExtensions;
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
            _file = Substitute.For<IFile>();
            _fixture = new Fixture();
        }
        
        [Test]
        public void FileProxyThrowsException_ExceptionSurfaced()
        {
            //SETUP
            var filePath = _fixture.Create<string>();
            var delimiter = "|";
            _file.ReadAllLines(Arg.Any<string>()).ThrowsForAnyArgs(new DataException("OH NO"));
            
            var SUT = new CsvParser(_file);

            //TEST
            TestDelegate testDelegate = () => SUT.Parse(filePath, delimiter);

            //VALIDATE
            var ex = Assert.Throws<DataException>(testDelegate);
            Assert.That(ex.Message.Contains("OH NO"), Is.True);
        }

        [Test]
        public void FileProxyReturnsNull_ThrowsException()
        {
            //SETUP
            var filePath = _fixture.Create<string>();
            var delimiter = "|";
            _file.ReadAllLines(Arg.Any<string>()).ReturnsNullForAnyArgs();

            var SUT = new CsvParser(_file);

            //TEST
            TestDelegate testDelegate = () => SUT.Parse(filePath, delimiter);

            //VALIDATE
            var ex = Assert.Throws<Exception>(testDelegate);
            Assert.That(ex.Message.Contains("No file lines exists"), Is.True);
        }

        [Test]
        public void BreakingTest()
        {
            //SETUP
            var filePath = _fixture.Create<string>();
            var delimiter = "|";
            _file.ReadAllLines(Arg.Any<string>())
                 .ReturnsForAnyArgs(new string[] { "100|1000", "200|A" });

            var SUT = new CsvParser(_file);

            //TEST
            var results = SUT.Parse(filePath, delimiter);

            //VALIDATE
            var list = results.ToList();
            Assert.That(list.Count, Is.EqualTo(2));
            var firstResult = list[0];
            Assert.That(firstResult.MfgItemId, Is.EqualTo(100));
            Assert.That(firstResult.ReferenceNumber, Is.EqualTo(1000));
        }

        [Test]
        public void CriticalPath()
        {
            //SETUP
            var filePath = _fixture.Create<string>();
            var delimiter = "|";
            _file.ReadAllLines(Arg.Any<string>())
                 .ReturnsForAnyArgs(new string[]{"100|1000","200|2000"});

            var SUT = new CsvParser(_file);

            //TEST
            var results = SUT.Parse(filePath, delimiter);

            //VALIDATE
            var list = results.ToList();
            Assert.That(list.Count, Is.EqualTo(2));
            var firstResult = list[0];
            Assert.That(firstResult.MfgItemId, Is.EqualTo(100));
            Assert.That(firstResult.ReferenceNumber, Is.EqualTo(1000));
        }

        private IFile _file;
        private Fixture _fixture;
    }
}