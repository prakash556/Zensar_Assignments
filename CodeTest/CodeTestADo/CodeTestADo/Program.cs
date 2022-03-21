using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CodeTestADo
{
    internal class Program
    {
        public static SqlCommand cmd;
        public static SqlConnection conn;
        public static SqlDataReader dr;
        static void Main(string[] args)
        {
            InsertEmployee();
            //Display();
            Console.ReadLine();
        }
        static void InsertEmployee()
        {
            conn=GetConnection();
            Console.Write("Enter Employee Name:");
            string name=Console.ReadLine();
            
            Console.Write("Enter Employee Salary:");
            float salary=float.Parse(Console.ReadLine());
            Console.Write("Enter Emplyee Type:");
            string type=Console.ReadLine();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "InsertEmpolyee";
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
           
            SqlParameter sp2 = new SqlParameter
            {
                ParameterName = "@name",
                SqlDbType = SqlDbType.VarChar,
                Value = name,
                Direction = ParameterDirection.Input,
            };
            SqlParameter sp3 = new SqlParameter
            {
                ParameterName = "@salary",
                SqlDbType = SqlDbType.Float,
                Value = salary,
                Direction = ParameterDirection.Input,
            };
            SqlParameter sp4 = new SqlParameter
            {
                ParameterName = "@type",
                SqlDbType = SqlDbType.VarChar,
                Value = type,
                Direction = ParameterDirection.Input,
            };
            
            cmd.Parameters.Add(sp2);
            cmd.Parameters.Add(sp3);
            cmd.Parameters.Add(sp4);
            int no_ofrows = cmd.ExecuteNonQuery();
            if (no_ofrows > 0)
            {
                Console.WriteLine("Number of Rows affected are : {0} ", no_ofrows);
            }


        }
        static void Display()
        {
            conn = GetConnection();
            cmd = new SqlCommand("select * from Employee", conn);
            
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("Employee Id:" + dr[0]);
                Console.WriteLine("Employee Name:" + dr[1]);
                Console.WriteLine("Employee Salary:" + dr[2]);
                Console.WriteLine("Employee Type:" + dr[3]);
            }
        }
        static SqlConnection GetConnection()
        {
            conn = new SqlConnection("data source=ADMW48ZLPC0350;initial catalog=EmployeeManagement;" +
                "integrated security=true");
            conn.Open();
            return conn;
        }
    }
}