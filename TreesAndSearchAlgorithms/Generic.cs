using System;
using System.Collections.Generic;

namespace TreesAndSearchAlgorithms
{
    public class Generic<TC>
    {
        public void Process(TC item)
        {
            Console.Write(item.ToString());
        }
    }
}