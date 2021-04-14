using System;

namespace ProxyDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Database database = new Database();

            database.Create(new MfgItem());

            DatabaseProxy proxy = new DatabaseProxy();

            proxy.Add(1);
        }
    }
}
