using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validationss
{
    internal class Product
    {
        public int Number { get; set; }
        public DateTime  Date { get; set; }
        public String InventoryNo { get; set; }
        public String ObjectName { get; set; }
        public int Count { get; set; }
        public double price { get; set; }
        public String Phoneno { get; set; }
        //we use ststic because the list is shared for all object
       static List<Product> products = new List<Product>();

        public void save()
        {
            //this: b/c it is in the same class
            products.Add(this);
        }
        static public List<Product> getAllProduct()
        {
            return products;
        }


    }
}
