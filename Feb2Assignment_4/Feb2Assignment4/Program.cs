using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Feb2Assignment_4;

namespace Feb2Assignment4
{
    internal class Program
    {
        public string Name;
        static int Age;
        const float TotalFare= 500;
        public Program()
        {
            Console.Write("Enter your Name:");
            Name = Console.ReadLine();
            Console.Write("Enter your Age:");
            Age =int.Parse(Console.ReadLine());
        }
        public static void Main(string[] args)
        {
            Program program = new Program();
            Class1 c=new Class1();
            c.CalculateConcession(Age, TotalFare);
            Console.ReadKey();
        }
    }
}
