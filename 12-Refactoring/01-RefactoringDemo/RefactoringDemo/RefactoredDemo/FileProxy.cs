using System.IO;

namespace RefactoredDemo
{
    public interface IFile
    {
        string[] ReadAllLines(string filePath);
    }
    
    public class FileProxy : IFile
    {
        public string[] ReadAllLines(string filePath)
        {
            return File.ReadAllLines(filePath);
        }
    }

    public class FakeFile : IFile
    {
        public string[] ReadAllLines(string filePath)
        {
            return new string[] { "12345,6789" };
        }
    }
}