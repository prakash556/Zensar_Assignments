using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan28_Assignment3
{
    internal class LoanProcess
    {
        //Declaring variables
        string CustomerName;
        int LoanNo,t;
        double LoanAmount;
        float EMI_Amount;
        double Account_Balance;
        float r;
        //taking input from the user, using constructor
        public LoanProcess()
        {
            Console.Write("Enter Customer Name:");
            CustomerName =Console.ReadLine();
            Console.Write("Enter Loan Number:");
            LoanNo =int.Parse(Console.ReadLine());
            Console.Write("Enter Loan Amount:");
            LoanAmount =double.Parse(Console.ReadLine());
            Console.Write("Enter Account Balance:");
            Account_Balance =double.Parse(Console.ReadLine());
            Console.Write("Enter rate of Interest:");
            r = float.Parse(Console.ReadLine());
            Console.Write("Enter Tenure of Loan in years:");
            t = int.Parse(Console.ReadLine());
        }
        //calculating monthly EMI for Loan Amount
        public void Calculate_EMI()
        {
            //LoanAmount is the amount user borrowed that is principle amount
            //13 is the 13% of interest for 3 years time 
            r = r/(12*100);//rate of interest per month
            t = 12*t;//time period in months
            EMI_Amount = (float)((LoanAmount*r*(Math.Pow(1+r,t)))/(Math.Pow(1+r,t)-1));
            Console.WriteLine("Your EMI Amount is:"+EMI_Amount+" and Your Account Balance is:"+Account_Balance);
        }
        public void CheckBalance()
        {
            if(Account_Balance<EMI_Amount)
            {
                throw new Exception("Not Sufficient Balance to Repay Loan");
            }
            else
            {
                Console.WriteLine("Your EMI is Paid Sucessfully");
            }
        }
        static void Main()
        {
            LoanProcess lp=new LoanProcess();
            lp.Calculate_EMI();
            try
            {
                lp.CheckBalance();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
}
