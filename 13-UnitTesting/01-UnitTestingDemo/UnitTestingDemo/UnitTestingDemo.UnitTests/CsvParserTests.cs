using NUnit.Framework;

namespace UnitTestingDemo.UnitTests
{
    public class CsvParserTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            CsvParser parser = new CsvParser();
            
            parser.Parse(@"C:\code\software-fundamentals\13-UnitTesting\data\data.csv");
        }
    }
}