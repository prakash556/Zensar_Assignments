using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan21_assignment
{
    internal class importmodule
    {
        static void Main()
        {
            //initializing new array with length of 10
            int[] array = new int[10];

            //Loop for storing 10 numbers
            Console.WriteLine("Enter 10 Marks Values: ");
            for (int i = 0; i < array.Length; i++)
            {
                int a = int.Parse(Console.ReadLine());
                array[i] = a;
            }

            //Priting Desired Output for the Program
            Console.WriteLine("Total Marks " + array.());
            Console.WriteLine("Average of Marks " + array.average());
        }
    }
}
