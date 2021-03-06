using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan28_Assignment3
{
    interface IStudent
    {
        string StudentName { get; set; }
        int StudentId { get; set; }
         void ShowDetails();
    }
    class Dayscholar : IStudent
    {
        string name;
        int Id;
        public string StudentName
        {
            get { return name; }
            set { name = value; }
        }
        public int StudentId
        {
            get { return Id; }
            set { Id = value; }
        }
        public void ShowDetails()
        {
            Console.WriteLine(StudentName+" is a Dayscholar student");
            Console.WriteLine("Day Scholar Student Id:"+StudentId);
        }
    }
    class Resident : IStudent
    {
        string RName;
        int RId;
        public string StudentName
        {
            get { return RName; }
            set { RName = value; }
        }
        public int StudentId
        {
            get { return RId; }
            set { RId = value; }
        }
        public void ShowDetails()
        {
            Console.WriteLine(StudentName+" is a Resident Student");
            Console.WriteLine("Resident Student Id:" + StudentId);
        }
    }
    internal class Interface1
    {
        static void Main()
        {
            IStudent student = new Dayscholar();
            student.StudentName = "Prakash";
            student.StudentId = 556;
            student.ShowDetails();
            IStudent student2 = new Resident();
            student2.StudentName = "Deekshith";
            student2.StudentId = 525;
           student2.ShowDetails();
            Console.Read();
        }
    }
}
