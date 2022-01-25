using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan21_assignment
{
    internal class Question3
    {
        static void Main()
        {
            //Reading 3 Numbers From User
            Console.Write("Enter value of Number1:");
            int Number1=int.Parse(Console.ReadLine());
            Console.Write("Enter value of Number2:");
            int Number2=int.Parse(Console.ReadLine());
            Console.Write("Enter value of Number3:");
            int Number3=int.Parse(Console.ReadLine());

            //Finding Largest And Smallest Number from 3 Numbers and Printing Result
            if (Number1>Number2 && Number1>Number3)
            {
                Console.WriteLine(Number1+" is Larger Number");
                if(Number3>Number2)
                {
                    Console.WriteLine(Number2 + " is Smaller Number");
                }
                else
                {
                    Console.WriteLine(Number3 + " is Smaller Number");
                }
                
            }
            else if (Number2 > Number3)
            {
                Console.WriteLine(Number2 + " is Larger Number");
                if (Number3 > Number1)
                {
                    Console.WriteLine(Number1 + " is Smaller Number");
                }
                else
                {
                    Console.WriteLine(Number3 + " is Smaller Number");
                }

            }
            else 
            {
                Console.WriteLine(Number3 + " is Larger Number");
                if (Number1 > Number2)
                {
                    Console.WriteLine(Number2 + " is Smaller Number");
                }
                else
                {
                    Console.WriteLine(Number1 + " is Smaller Number");
                }

            }
            Console.ReadKey();

        }
    }
}
