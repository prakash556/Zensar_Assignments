using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan21_assignment
{
    internal class Question1
    {
        static void Main(string[] args)
        {
            //taking Username from User
            Console.Write("Enter Username:");
            string Name=Console.ReadLine();

            //Printing Desired Output
            Console.WriteLine("Hi! "+Name+ " Welcome to the world of C#");
            Console.ReadKey();
        }
    }
}
