using System;

namespace BuilderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new SequenceBuilder();
            builder.AminoAcidA();
            builder.BaseA();

            var query = 
                new QueryBuilder()
                    .Select("*")
                    .From("MfgItem", "mi")
                    .Join("Specification", "s", "mi.SpecificationId", "SpecificationId")
                    .WhereEquals("mi.MfgItemId", 17)
                    .Build();

            var queryV2 = 
                new QueryBuilderV2()
                    .Select("*")
                    .From("MfgItem", "mi")
                    .Join("Specification", "s", "mi.SpecificationId", "SpecificationId")
                    .Join("WorkOrder", "wo", "s.SpecificationId", "SpecificationId")
                    .WhereEquals("mi.MfgItemId", 17);

            Console.WriteLine(queryV2);
        }
    }
}
