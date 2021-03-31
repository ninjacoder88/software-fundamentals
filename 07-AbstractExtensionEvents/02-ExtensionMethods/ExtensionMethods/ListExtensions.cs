using System.Collections.Generic;

namespace ExtensionMethods
{
    public static class ListExtensions
    {
        public static bool ContainsEven(this List<int> list)
        {
            foreach(var item in list)
            {
                if(item % 2 == 0)
                    return true;
            }

            return false;
        }
    }
}