using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DebuggerDemo
{
    public class Processor
    {
        public Processor(ILogger logger)
        {
            _logger = logger;
        }

        public void Process(string filePath, int minimumQuantity)
        {
            string[] fileLines = File.ReadAllLines(filePath);

            var items = new List<Item>();
            foreach (var fileLine in fileLines)
            {
                string[] splitFileLine = fileLine.Split(new[] {"|"}, StringSplitOptions.None);

                decimal price = decimal.Parse(splitFileLine[3]);
                
                items.Add(new Item
                              {
                                  Id = int.Parse(splitFileLine[0]),
                                  Name = splitFileLine[1],
                                  Description = splitFileLine[2],
                                  Price = price
                              });
            }

            var itemsGroupedByName = items.GroupBy(x => x.Name).ToList();

            foreach (var groupOfItems in itemsGroupedByName)
            {
                int quantity = groupOfItems.Count();
                if(quantity <= minimumQuantity)
                    _logger.Log($"{groupOfItems.Key} - {quantity} - REORDER");
                else
                    _logger.Log($"{groupOfItems.Key} - {quantity}");
            }
        }

        private readonly ILogger _logger;
    }

    public class Item
    {
        public string Description { get; set; }

        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}