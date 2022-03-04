using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb2Assignment_4
{
    public class Class1
    {
        public void CalculateConcession(int age,float fare)
        {
            if(age<=5)
            {
                Console.WriteLine("Little Champs- Free Ticket");
            }
            else if(age>60)
            {
                //declaring variable with value of total fare - 30% Concession 
                float a = fare-150;

                Console.WriteLine("Senior Citizen Your Fair is: "+a);
            }
            else
            {
                Console.WriteLine("Ticket Booked your Fair is: "+fare);
            }
            
        }
    }
}
