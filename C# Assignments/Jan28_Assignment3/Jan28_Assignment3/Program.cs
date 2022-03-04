using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan28_Assignment3
{
    //Defining Exeception Class
    class UserDefinedException : Exception
    {
        public UserDefinedException(string msg):base(msg)
        {

        }
    }
    //Defining class Passenger With Multiple Variables And with a Method.
    class Passenger
    {
        public string Name;
        public int age;

        //Defining a method which will check for condition.
        //if condition satiesfies then it prints Successful Message
        //if condition fail it throws exception to Exception class
        public void TicketBooking(int no_of_tickets)
        {
            if(no_of_tickets>5)
            {
                throw(new UserDefinedException("Cannot Book Morethan 5 Tickets"));
            }
            else
            {
                Console.WriteLine("Ticket Booked Successfully");
            }
        }
        //difined a method to print the details of the passenger who booked tickets
        public void Details()
        {
            Console.WriteLine("=====Details Of Passenger======");
            Console.WriteLine("Name of Passenger:"+Name);
            Console.WriteLine("Age of Passenger:"+age);
        }
    }
    internal class Program
    {
        //defining main method where program execution starts
        static void Main(string[] args)
        {
            Passenger ps = new Passenger();//creating class object to Access Methods and variable in that class
            ps.Name = "Prakash";
            ps.age = 22;
            Console.Write("Enter Number of Tickets you want to Book:");
            int n=int.Parse(Console.ReadLine());
            //implementing try and catch statement to catch exceptions if any occurs
            try
            {
                ps.TicketBooking(n);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            ps.Details();
            Console.Read();
        }
    }
}
