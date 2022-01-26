using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan25_Assignment2
{
    public abstract class Student1
    {
        string StudentName;
        int StudentId;
        public void Data()
        {
            Console.Write("Enter Student Name:");
            StudentName =Console.ReadLine();
            Console.Write("Enter StudentId:");
            StudentId = int.Parse(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine("Name of the Student: "+StudentName);
            Console.WriteLine("Student Id: "+StudentId);
        }
        public abstract Boolean Ispassed(float s);
    }
    class UnGraduate:Student1
    {
        public override Boolean Ispassed(float s)
        {
            if(s>70.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class Graduate:Student1
    {
        public override bool Ispassed(float s)
        {
            if (s > 80.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class program1
    {
        static void Main()
        {
            float Grade;
            bool result;
            Graduate g = new Graduate();
            g.Data();
            Console.Write("Enter Student Grade:");
            Grade=float.Parse(Console.ReadLine());
            result=g.Ispassed(Grade);
            
            if (result)
            {
                Console.WriteLine("Graduate Student is Pass");
            }
            else
            {
                Console.WriteLine("Graduate Student is Fail");
            }
            UnGraduate ung = new UnGraduate();
            result = ung.Ispassed(Grade);
            if (result)
            {
                Console.WriteLine("UnderGraduate Student is Pass");
            }
            else
            {
                Console.WriteLine("UnderGraduate Student is Fail");
            }
            g.Display();
            Console.WriteLine("Grade of Student:"+Grade);
            Console.Read();
        }
    }
}
