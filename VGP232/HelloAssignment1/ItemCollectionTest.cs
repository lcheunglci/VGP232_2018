using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.IO;

namespace HelloConsole
{
    [TestFixture]
    public class ItemCollectionTest
    {
        const string TEST_FILE = "test.csv";
        string fullPathToTest = "";
        ItemCollection collection;

        [SetUp]
        public void Setup()
        {
            fullPathToTest = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), TEST_FILE);

            StreamWriter writer = new StreamWriter(fullPathToTest);
            writer.WriteLine("Name,Quantity,Price");
            writer.WriteLine("Endive,176,0.22"); // most quantity
            writer.WriteLine("Okra,94,0.92"); // most expensive
            writer.WriteLine("Garlic,23,0.59");
            writer.Close();

            collection = new ItemCollection();

            bool success = collection.Parse(fullPathToTest);

            Assert.IsTrue(success, "File cannot be parsed");

            Assert.AreEqual(collection.Count, 3);

        }

        [TearDown]
        public void Cleanup()
        {
            collection.Clear();
            if (File.Exists(fullPathToTest))
            {
                File.Delete(fullPathToTest);
            }
            else
            {
                Console.WriteLine(fullPathToTest);
            }
            
        }

        //[Test]
        //public void ItemCollection_Parse_Returns_true()
        //{
        //    bool success = collection.Parse(fullPathToTest);

        //    Assert.IsTrue(success, "File cannot be parsed");

        //    Assert.AreEqual(collection.Count, 3);
        //}

        [Test]
        public void ItemCollection_MostExpensiveItem_Price_0_92()
        {
            Assert.AreEqual(collection.MostExpensiveItem().Price, 0.92f);
        }

        [Test]
        public void ItemCollection_MostQuantityItem_Price_176()
        {
            Assert.AreEqual(collection.MostQuantityItem().Quantity, 176);
        }


        //ItemCollection_MostExpensiveItem_Returns_

    }
}
