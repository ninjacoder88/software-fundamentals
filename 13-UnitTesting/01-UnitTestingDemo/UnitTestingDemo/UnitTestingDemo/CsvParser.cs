using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;

namespace UnitTestingDemo
{
    public class CsvParser
    {
        public void Parse(string filePath)
        {
            var fileLines = File.ReadAllLines(filePath).ToList();

            var csvMfgItems = new List<CsvMfgItem>();
            foreach (var fileLine in fileLines)
            {
                string[] splitFileLine = fileLine.Split(new[] { "," }, StringSplitOptions.None);

                csvMfgItems.Add(new CsvMfgItem
                {
                    MfgItemId = int.Parse(splitFileLine[0]),
                    ReferenceNumber = int.Parse(splitFileLine[1])
                });
            }

            string mfgItemIds = string.Join(",", csvMfgItems.Select(x => x.MfgItemId));
            string query = "SELECT mi.MfgItemId, il.Barcode " +
                           "FROM MfgItem AS mi WITH (NOLOCK) " +
                           "JOIN dbo.InventoryMfgItemLink AS imil WITH (NOLOCK) ON mi.MfgItemId = imil.MfgItemId " +
                           "JOIN dbo.InventoryLocation AS il WITH (NOLOCK) ON imil.InventoryLocationId = il.InventoryLocationId " +
                           $"WHERE mi.MfgItemId IN ({mfgItemIds})";

            var mfgItemBarcodes = new List<MfgItemBarcode>();
            using (var connection = new SqlConnection("Server=cordevsqlv37;Database=ManufacturingData;Trusted_Connection=true;"))
            {
                var command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    mfgItemBarcodes.Add(new MfgItemBarcode()
                    {
                        MfgItemId = (int)reader[0],
                        Barcode = int.Parse((string)reader[1])
                    });
                }
                reader.Close();
            }

            var results =
                from cmi in csvMfgItems
                join mb in mfgItemBarcodes on cmi.MfgItemId equals mb.MfgItemId
                select new { cmi.MfgItemId, cmi.ReferenceNumber, mb.Barcode };

            foreach (var mfgItemBarcode in results.ToList())
            {
                Console.WriteLine($"{mfgItemBarcode.MfgItemId},{mfgItemBarcode.ReferenceNumber},{mfgItemBarcode.Barcode}");
            }
        }
    }
}