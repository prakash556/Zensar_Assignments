using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan21_assignment
{
    internal class Question7
    {
        static void Main()
        {
            //initializing new array with length of 10
            int[] array =new int[10];

            //Loop for storing 10 numbers
            Console.WriteLine("Enter 10 Marks Values: ");
            for (int i = 0; i < array.Length; i++)
            {
                int a=int.Parse(Console.ReadLine());
                array[i] = a;
            }

            //Priting Desired Output for the Program
            Console.WriteLine("Total Marks "+array.Sum());
            Console.WriteLine("Average of Marks " + array.Average());
            Console.WriteLine("Maximum Marks "+array.Max());
            Console.WriteLine("Minimum Marks "+array.Min());
            Array.Sort(array);
            Console.WriteLine("Ascending Order of Marks");
            Console.WriteLine(string.Join(" ", array));
            Array.Reverse(array);
            Console.WriteLine("Descending Order of Marks");
            Console.WriteLine(string.Join(" ", array));
            Console.ReadKey();
        }
    }
}
