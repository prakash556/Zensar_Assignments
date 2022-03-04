using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan28_Assignment3
{
    struct Employ
    {
        public string Empname;
        public Date_of_birth Dob;

    }
    struct Date_of_birth
    {
        public int date;
        public int month;
        public int year;
    }
    internal class Nested_structure
    {
        static void Main()
        {
            Employ[] emp=new Employ[2];
            for(int i=0;i<2;i++)
            {
                Console.Write("Name of the Employee:");
                emp[i].Empname = Console.ReadLine();
                

                Console.Write("Input Enter Day of the Birth:");
                emp[i].Dob.date = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input Enter Month of the Birth:");
                emp[i].Dob.month = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input Enter year of the Birth:");
                emp[i].Dob.year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

            }
            for(int i=0;i<2; i++)
            {
                if(i==0)
                {
                    Console.WriteLine("===============OUTPUT=================");
                }
                
                Console.WriteLine("Name of the Employee:{0}", emp[i].Empname);
                Console.WriteLine("Date of birth of Employee:{0}-{1}-{2}", emp[i].Dob.date, emp[i].Dob.month, emp[i].Dob.year);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
