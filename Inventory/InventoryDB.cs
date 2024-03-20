using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    internal class InventoryDB
    {
        private const string Path = @"..\..\..\grocery_inventory_items.txt";
        private const Char Delimiter = '|';


        public static List<InventoryItem> GetItems()
        {
            // create the list
            List<InventoryItem> items = new List<InventoryItem>();


            // create the object for the input stream for a text file
            using (StreamReader textIn =
                new StreamReader(
                new FileStream(Path, FileMode.OpenOrCreate, FileAccess.Read)))
            {
                // read the data from the file and store it in the list
                while (textIn.Peek() != -1)
                {
                    string row = textIn.ReadLine() ?? "";
                    string[] columns = row.Split(Delimiter);


                    if (columns.Length == 3)
                    {
                        InventoryItem item = new InventoryItem()
                        {
                            ItemNo = Convert.ToInt32(columns[0]),
                            Description = columns[1],
                            Price = Convert.ToDecimal(columns[2])
                        };
                        items.Add(item);
                    }
                }
            }
            // close the input stream for the text file
            //textIn.Close();
            return items;
        }


        public static void SaveItems(List<InventoryItem> items)
        {
            // create the output stream for a text file that exists
            using (StreamWriter textOut =
                new StreamWriter(
                new FileStream(Path, FileMode.Create, FileAccess.Write)))
            {
                // write each item
                foreach (InventoryItem item in items)
                {
                    textOut.Write(item.ItemNo + Delimiter);
                    textOut.Write(item.Description + Delimiter);
                    textOut.WriteLine(item.Price);
                }
            }




            // close the output stream for the text file
            //textOut.Close();
        }
    }
}
