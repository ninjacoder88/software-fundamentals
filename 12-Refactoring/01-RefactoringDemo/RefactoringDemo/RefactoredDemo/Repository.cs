using System.Collections.Generic;
using System.Data.SqlClient;

namespace RefactoredDemo
{
    public interface IRepository
    {
        IEnumerable<MfgItemBarcode> Load(string mfgItemIds);
    }

    public class Repository : IRepository
    {
        public Repository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<MfgItemBarcode> Load(string mfgItemIds)
        {
            string query = "SELECT mi.MfgItemId, il.Barcode " +
                           "FROM MfgItem AS mi WITH (NOLOCK) " +
                           "JOIN dbo.InventoryMfgItemLink AS imil WITH (NOLOCK) ON mi.MfgItemId = imil.MfgItemId " +
                           "JOIN dbo.InventoryLocation AS il WITH (NOLOCK) ON imil.InventoryLocationId = il.InventoryLocationId " +
                           $"WHERE mi.MfgItemId IN ({mfgItemIds})";

            var mfgItemBarcodes = new List<MfgItemBarcode>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    mfgItemBarcodes.Add(new MfgItemBarcode
                                            {
                                                MfgItemId = (int) reader[0],
                                                Barcode = int.Parse((string) reader[1])
                                            });
                }

                reader.Close();
            }

            return mfgItemBarcodes;
        }

        private readonly string _connectionString;
    }
}