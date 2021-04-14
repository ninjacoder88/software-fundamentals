namespace BuilderDemo
{
    public class QueryBuilder
    {
        public QueryBuilder Select(string columns)
        {
            _query += $"SELECT {columns}";
            return this;
        }

        public QueryBuilder From(string table, string alias)
        {
            _query += $"\r\nFROM {table} AS {alias} WITH (NOLOCK)";
            return this;
        }

        public QueryBuilder Join(string table, string alias, string leftColumnWithAlias, string rightColumn)
        {
            _query += $"\r\nJOIN {table} AS {alias} WITH (NOLOCK) ON {leftColumnWithAlias} = {alias}.{rightColumn}";
            return this;
        }

        public QueryBuilder WhereEquals(string columnWithAlias, int value)
        {
            _query += $"\r\nWHERE {columnWithAlias} = {value}";
            return this;
        }

        public string Build()
        {
            return _query;
        }

        private string _query;
    }
}