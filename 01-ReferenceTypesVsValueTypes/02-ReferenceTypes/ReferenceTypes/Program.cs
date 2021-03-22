using System;

namespace ReferenceTypes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Thing t1 = new Thing();
            t1.Id = 7;
            t1.Name = "Seven";
            Console.WriteLine(t1);

            Thing t2 = new Thing();
            t2.Id = 8;
            t2.Name = "Eight";
            Console.WriteLine(t2);

            t1 = t2;
            t2.Id = 9;

            Console.WriteLine(t1.Id);
            Console.WriteLine(t2.Id);
        }
    }

    public class Thing
    {
        public int Id {get;set;}
        public string Name {get;set;}
    }
}
