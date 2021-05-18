using System;

namespace RefactoredDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IFile file = new FileProxy();
            IRepository repository = new Repository("Server=cordevsqlv37;Database=ManufacturingData;Trusted_Connection=true;");
            IOutputProxy outputProxy = new OutputProxy();
            ICsvParser parser = new CsvParser(file);
            
            Processor processor = new Processor(repository, outputProxy, parser);
            processor.Process(@"C:\code\software-fundamentals\12-Refactoring\data\data.csv", ",");
        }
    }
}
