namespace ProxyDemo
{
    public class DatabaseProxy
    {
        public DatabaseProxy()
        {
            _database = new Database();
        }

        public void Add(int id)
        {
            _database.Create(new MfgItem(){Id = id});
        }

        private Database _database;
    }
}