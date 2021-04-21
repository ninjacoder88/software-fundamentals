using System.Collections.Generic;

namespace BuilderDemo
{
    public class QueryBuilderV2
    {
        public FromQueryBuilder Select(string columns)
        {
            return new FromQueryBuilder($"SELECT {columns}");
        }
    }

    public class FromQueryBuilder
    {
        public FromQueryBuilder(string query)
        {
            _query = query + "\r\n";
        }

        public SelectFromQueryBuilder From(string table, string alias)
        {
            var newQuery = _query + $"FROM dbo.{table} AS {alias} WITH (NOLOCK)";
            return new SelectFromQueryBuilder(newQuery);
        }

        public string Build()
        {
            return $"{_query};";
        }

        private string _query;
    }

    public class SelectFromQueryBuilder
    {
        public SelectFromQueryBuilder(string query)
        {
            _query = query;
        }

        public JoinQueryBuilder Join(string table, string alias, string joinColumnWithAlias, string rightColumn)
        {
            return new JoinQueryBuilder(_query).Join(table, alias, joinColumnWithAlias, rightColumn);
        }

        public string WhereEquals(string whereTable, string whereColumnWithAlias, int value)
        {
            return new WhereQueryBuilder(_query).WhereEquals(whereColumnWithAlias, value);
        }
        
        private string _query;
    }

    public class JoinQueryBuilder
    {
        public JoinQueryBuilder(string query)
        {
            _query = query + "\r\n";
        }

        public JoinQueryBuilder Join(string table, string alias, string joinColumnWithAlias, string rightColumn)
        {
            var newQuery = _query + $"JOIN dbo.{table} AS {alias} WITH (NOLOCK) ON {joinColumnWithAlias} = {alias}.{rightColumn}";
            return new JoinQueryBuilder(newQuery);
        }

        public string WhereEquals(string whereColumnWithAlias, int value)
        {
            return new WhereQueryBuilder(_query).WhereEquals(whereColumnWithAlias, value);
        }

        public string Build()
        {
            return $"{_query};";
        }

        private string _query;
    }

    public class WhereQueryBuilder
    {
        public WhereQueryBuilder(string query)
        {
            _query = query;
        }

        public string WhereEquals(string whereColumnWithAlias, int value)
        {
            return _query + $"WHERE {whereColumnWithAlias} = {value};";
        }

        private string _query;
    }
}