using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan21_assignment
{
    internal class Question6
    {
        static void Main()
        {
            //Creating array with 10 Elements
            int[] array = new int[] { 10, 45, 56, 37, 87, 23, 65, 90, 22, 2 };

            //Printing Desired Output Using Array Functions
            Console.WriteLine("Length of Array:"+array.Length);
            Console.WriteLine("Average Value of Array is: "+array.Average());
            Console.WriteLine("Miximum Value in Array is: " + array.Max());
            Console.WriteLine("Minimum Value in Array is: "+array.Min());
            Console.ReadKey();
        }
    }
}
