using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb2Assignment4
{
    internal class Stationary
    {
        public void Add()
        {
            var items = new List<string>();
            Console.Write("Enter Number of items you want to add:");
            int n =int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter item {0} to add:",i+1);
                string it = Console.ReadLine();
                items.Add(it);
            }
            Console.WriteLine("Items that you are added Recently are:");
            foreach(string item in items)
                Console.WriteLine(item);
        }
        static void Main()
        {
            Stationary st=new Stationary();
             st.Add();
            Console.ReadKey();

        }

    }
}
