using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan21_assignment
{
    internal class Question5
    {
        static void Main()
        {
            //Reading Temperature in Fahrenheit
            Console.Write("Enter Temperature in Fahrenheit:");
            int temp_far=int.Parse(Console.ReadLine());

            //Converting to Celsius
            float temp_cel = (temp_far - 32) * (0.5556f) ;

            //Printing Result After Conversion
            Console.WriteLine("Temperature in Celsius:{0}C",temp_cel);
            Console.ReadKey();
        }
    }
}
