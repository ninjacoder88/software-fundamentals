using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtensionMethods
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Repository r = new Repository();
            // var entity = r.Load();

            // MfgItemModel mfgItemModel = entity.ToModel();

            // Console.WriteLine(mfgItemModel.Concentration);


            List<int> intList = new List<int>();
            intList.Add(1);
            //intList.Add(2);
            intList.Add(3);
            //intList.Add(4);
            intList.Add(5);

            intList.Any();
            Console.WriteLine(intList.ContainsEven());
        }
    }
}
