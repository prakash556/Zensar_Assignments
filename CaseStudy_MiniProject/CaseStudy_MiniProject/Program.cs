using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    //CASE STUDY 1
    class Student
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public DateOnly DOB { get; set; }
        public Student(string name, int id, DateOnly dob)
        {
            this.Name = name;
            this.Id = id;
            this.DOB = dob;
        }
    }
    class Course
    {
        public string CourseName { get; set; }
        public int CourseId { get; set; }

        public String Duration { get; set; }
        public double Fees { get; set; }
        public Course(string name, int id, string duration, double fees)
        {
            this.CourseName = name;
            this.CourseId = id;
            this.Duration = duration;
            this.Fees = fees;
        }
    }
    class Info
    {
        public void DisplayStudent(Student student)
        {
            Console.WriteLine("Student Id:" + student.Id);
            Console.WriteLine("Student Name:" + student.Name);
            Console.WriteLine("Student Dateof Birth:" + student.DOB);
        }
        public void DisplayCourse(Course course)
        {
            Console.WriteLine("Course Id:" + course.CourseId);
            Console.WriteLine("Course Name:" + course.CourseName);
            Console.WriteLine("Course Duration:" + course.Duration);
            Console.WriteLine("Course Fees:" + course.Fees);
        }
       
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Program p = new Program();
            p.Scenario1();
            p.Scenario2();
            p.Scenario3();
            AddCourses();
            Console.Read();
        }
        public void Scenario1()
        {
            Info i = new Info();
            Student s1 = new Student("Magesh", 530, DateOnly.ParseExact("16/03/1997", "dd/MM/yyyy"));
            i.DisplayStudent(s1);
        }
        public void Scenario2()
        {
            Info i1 = new Info();
            Student[] array = new Student[5];
            array[0] = new Student("Prakash", 556, DateOnly.ParseExact("12/12/1999", "dd/MM/yyyy"));
            array[1] = new Student("Sandeep", 513, DateOnly.ParseExact("08/08/1998", "dd/MM/yyyy"));
            array[2] = new Student("deekshith", 525, DateOnly.ParseExact("03/11/1999", "dd/MM/yyyy"));
            //i1.Display(array[0]);
            //i1.Display(array[1]);
            //i1.Display(array[2]);
            Console.WriteLine("******* Array Iterator *********");
            for (int i = 0; i <= 2; i++)
            {
                i1.DisplayStudent(array[i]);
                Console.WriteLine("------------------------");
            }
        }
        public void Scenario3()
        {
            Info i1 = new Info();
            // Student s1 = new Student(int.Parse(Console.ReadLine()), Console.ReadLine(), DateOnly.ParseExact(Console.ReadLine(), "dd/MM/yyyy"));
            Console.WriteLine("Enter How Many Students you want to Add:");
            int n = int.Parse(Console.ReadLine());
            Student[] stdarray = new Student[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter Student " + (i + 1) + " details:");
                Console.Write("Enter the Student Name:");
                string nm = Console.ReadLine();
                Console.Write("Enter Student ID:");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Enter Student Date of Birth:");
                DateOnly d = DateOnly.ParseExact(Console.ReadLine(), "dd/MM/yyyy");
                stdarray[i] = new Student(nm, id, d);
                Console.WriteLine("==========================================");
            }
            for (int i = 0; i < stdarray.Length; i++)
            {
                Console.WriteLine("Student " + (i + 1) + " Details are:");
                i1.DisplayStudent(stdarray[i]);
                Console.WriteLine("-------------------");
            }

        }
        static void AddCourses()
        {
            Info i1 = new Info();

            Console.WriteLine("Enter How Many Courses  you want to Add:");
            int n = int.Parse(Console.ReadLine());
            Course[] crsarray = new Course[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter Course " + (i + 1) + " details:");
                Console.Write("Enter the Course Name:");
                string cm = Console.ReadLine();
                Console.Write("Enter Course ID:");
                int cd = int.Parse(Console.ReadLine());
                Console.Write("Enter Course Duration:");
                string d = Console.ReadLine();
                Console.Write("Enter Course Fees:");
                double fe = Double.Parse(Console.ReadLine());
                crsarray[i] = new Course(cm, cd, d, fe);
                Console.WriteLine("==========================================");
            }
            for (int i = 0; i < crsarray.Length; i++)
            {
                Console.WriteLine("Course " + (i + 1) + " Details are:");
                i1.DisplayCourse(crsarray[i]);
                Console.WriteLine("-------------------");
            }
        }
    }
}
