using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloConsole
{
    public class ItemFactory
    {
        public static Item CreateItem(string data)
        {
            string[] tokens = data.Split(',');

            if (tokens.Length != 3)
            {
                return null;
            }

            string name = tokens[0];
            int quantity = 0;
            float price = 0;
            try
            {
                quantity = int.Parse(tokens[1]);
                price = float.Parse(tokens[2]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

            Item result = new Item() { Name = name, Price = price, Quantity = quantity };

            return result;
        }
    }

    public class Item
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }

        public float Total
        {
            get { return Quantity * Price; } 
        }

    }
}
