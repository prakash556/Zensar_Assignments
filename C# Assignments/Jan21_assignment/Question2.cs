using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan21_assignment
{
    internal class Question2
    {
        static void Main(string[] args)
        {
            //Reading Input From User
            Console.Write("Enter Number to check Even or Odd:");
            int Number = int.Parse(Console.ReadLine());

            //Checking and Printing if Number is Even Or Odd
            if (Number % 2 == 0)
            {
                Console.WriteLine(Number + " is Even Number");
            }
            else
            {
                Console.WriteLine(Number + " is Odd Number");
            }
            Console.ReadKey();
        }
    }
}
