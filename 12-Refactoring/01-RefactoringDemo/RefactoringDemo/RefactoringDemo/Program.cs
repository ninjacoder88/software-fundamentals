using System;

namespace RefactoringDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CsvParser parser = new CsvParser();
            parser.Parse(@"C:\code\software-fundamentals\12-Refactoring\data\data.csv");
        }
    }
}
