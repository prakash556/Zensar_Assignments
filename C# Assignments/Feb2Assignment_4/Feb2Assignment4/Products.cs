using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb2Assignment4
{
    internal class Products
    {
        public int ProductId;
        public string ProductName;
        public float Price;
        public void Operation()
        {
            int n = 10;
            SortedList<float,string> list = new SortedList<float, string>();
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter Product Name:");
                ProductName=Console.ReadLine();
                //Console.Write("Enter Product Id:");
                //ProductId=int.Parse(Console.ReadLine());
               // prodid.Add(ProductId);
                Console.Write("Enter Product Price:");
                Price=float.Parse(Console.ReadLine());
                list.Add(Price,ProductName);
            }
            foreach (KeyValuePair<float, string> kv in list)
            {
                Console.WriteLine("Price of product:"+kv.Key + " " +"Product Price:"+ kv.Value);
            }

        }
        static void Main()
        {
            Products products = new Products();
            products.Operation();
            Console.ReadKey();
        }
    }
}
