using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace HelloConsole
{
    public class ItemCollection : List<Item>
    {
        //bool Parse(string fileName)

        public Item MostExpensiveItem()
        {
            return this.OrderByDescending(item => item.Price).First();
        }

        public Item MostQuantityItem()
        {
            return this.OrderByDescending(item => item.Quantity).First();
        }

        public float CompleteTotal
        {
            get
            {
                float sum = 0;
                for (int i = 0; i < this.Count; i++)
                {
                    sum += this[i].Total;
                }

                return sum;
            }
        }

        public bool Parse(string fileName)
        { 
            StreamReader reader = null;
            try
            {
                reader = new StreamReader(fileName);
            }
            catch (FileNotFoundException)
            {
                return false;
            }

            string line = reader.ReadLine();
            line = reader.ReadLine();

            while (line != null)
            {
                //"Endive,76,0.22"
                Item item = ItemFactory.CreateItem(line);
                if (item != null)
                {
                    this.Add(item);
                }
                line = reader.ReadLine();
            }

            reader.Close();

            return true;

        }

        public void Save(string outputFile, bool append, bool includeCount, bool includeSum)
        {
            if (!string.IsNullOrEmpty(outputFile))
            {
                FileStream fs;

                if (append && File.Exists((outputFile)))
                {
                    fs = File.Open(outputFile, FileMode.Append);
                }
                else
                {
                    fs = File.Open(outputFile, FileMode.Create);
                }

                using (StreamWriter writer = new StreamWriter(fs))
                {
                    if (includeCount)
                    {
                        writer.WriteLine("There are {0} entries", this.Count);
                    }

                    if (includeSum)
                    {
                        writer.WriteLine("Sum of all the values is {0}", CompleteTotal);
                    }

                    for (int i = 0; i < this.Count; i++)
                    {
                        writer.WriteLine(this[i]);
                    }
                }
            }
        }
    }
}
