using System.Collections.Generic;

namespace ProxyDemo
{
    public class Database
    {
        public void Create(MfgItem mfgItem)
        {

        }

        public List<MfgItem> Read()
        {
            return new List<MfgItem>();
        }

        public void Update(MfgItem mfgItem)
        {

        }

        public void Delete(int id)
        {
            
        }
    }

    public class MfgItem
    {
        public int Id {get;set;}
    }
}