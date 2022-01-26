using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan25_Assignment2
{
    internal class Student
    {
        int RollNo;
        string Name;
        string Class;
        string Sem;
        string Branch;
        int[] Marks = new int[5];
        public  Student()
        {
            Console.Write("Enter Name Of The Student:");
            Name =Console.ReadLine();
            Console.Write("Enter RollNO Of The Student:");
            RollNo = int.Parse(Console.ReadLine());
            Console.Write("Enter Class Of The Student:");
            Class = Console.ReadLine();
            Console.Write("Enter Sem Of The Student:");
            Sem = Console.ReadLine();
            Console.Write("Enter Branch Of The Student:");
            Branch = Console.ReadLine();
            Console.WriteLine("Enter Student Marks");
            for(int i=0;i<Marks.Length;i++)
            {
                Console.Write("Enter Marks in Subject "+(i+1)+":");
                Marks[i] = int.Parse(Console.ReadLine());
            }
        }
        public void DisplayResult()
        {
            Console.WriteLine("=====Student Result======");
            double avg = Marks.Average();
            int sum = Marks.Sum();
            for (int i = 0; i < Marks.Length; i++)
            {
                if (Marks[i] < 35)
                {
                    Console.WriteLine(Name + " is Fail");
                    break;
                }
            
                else if (sum > 35 && avg < 50)
                {
                    Console.WriteLine(Name + " is Fail");
                    break;
                }
                else
                {
                    Console.WriteLine(Name + " is Pass");
                    break;
                }
            }

        }
        public void DisplayData()
        {
            Console.WriteLine("=======Student Data=======");
            Console.WriteLine("Name Of The Student is :"+Name);
            Console.WriteLine("RollNo Of The Student is :"+RollNo);
            Console.WriteLine("Class Of The Student is:"+Class);
            Console.WriteLine("Semister Of Student is:"+Sem);
            Console.WriteLine("Branch Of The Student is:"+Branch);
            Console.WriteLine("Marks Of Student is");
            Console.WriteLine(string.Join(" ", Marks));
        }
        static void Main()
        {
            Student st=new Student();
            st.DisplayResult();
            st.DisplayData();
            Console.ReadKey();
        }
    }
}
