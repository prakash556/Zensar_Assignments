using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan21_assignment
{
    internal class Question4
    {
        static void Main()
        {
            int csharp,html,sql;

            //Loop for Taking 5 students Marks
            for (int i = 1; i <6;i++)
            {
                Console.WriteLine("Enter Student"+i+" Marks");

                //Giving and storing Marks in Subject Variables
                Console.Write("Enter Marks in C#:");
                csharp = int.Parse(Console.ReadLine());
                Console.Write("Enter Marks in HTML:");
                html = int.Parse(Console.ReadLine());
                Console.Write("Enter Marks in SQL:");
                sql = int.Parse(Console.ReadLine());

                //Finding Average and Printing Result of Fail or Pass
                float avg = (csharp + html + sql) / 3;
                if(avg<50)
                {
                    Console.WriteLine("Student" + i + " is Fail");
                }
                else
                {
                    Console.WriteLine("Student" + i + " is Pass");
                }
                Console.WriteLine("---------------------------");
            }
        }
    }
}
