using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan25_Assignment2
{
    internal class Accounts
    {
        double AccountNo;
        string CustomerName;
        string AccountType;
        int TransactionType;
        double Amount;
        double Balance = 0;
        public Accounts()
        {
            Console.Write("Enter Customer Name:");
            CustomerName = Console.ReadLine();
            Console.Write("Enter Account Number:");
            AccountNo = double.Parse(Console.ReadLine());
            Console.Write("Enter Account Type:");
            AccountType = Console.ReadLine();
            while (true)
            {
                Console.WriteLine("Enter 1 for Deposit  ");
                Console.WriteLine("Enter 2 for WithDrawl  ");
                Console.WriteLine("Enter 3 to Check Balanace ");
                TransactionType = int.Parse(Console.ReadLine());
                Transaction_Type(TransactionType);
                Console.WriteLine("Enter 4 to quit Transaction: ");
                Console.Write("Press any Other Key to Continue Transaction");
                string quit = (Console.ReadLine());
                if (quit == "4")
                    break;
            }
        }
        public void Deposit(double Amount)
        {
            Balance+=Amount;
        }
        public void WithDrawl(double Amount)
        {
            Balance-=Amount;
        }
        public void Transaction_Type(int s)
        {
            if (s == 1)
            {
                Console.Write("Enter Amount to Deposit:");
                Amount = double.Parse(Console.ReadLine());
                Deposit(Amount);
                Console.WriteLine("Deposit is Successful Check Your Balance");
            }
            else if (s == 2)
            {
                Console.Write("Enter Amount to WithDrawl:");
                Amount = double.Parse(Console.ReadLine());
                if (Balance >= Amount)
                {
                    WithDrawl(Amount);
                    Console.WriteLine("WithDrawl is Successful Check Your Balance");
                }
                else
                {
                    Console.WriteLine("Insufficient Balance");
                }
            }
            else if (s == 3)
            {
                Console.WriteLine("Available Balance is Rs." + Balance);
            }
            else
            {
                Console.WriteLine("Enter Valid Transaction Type");
            }
        }

        public void ShowData()
        {
            Console.WriteLine("======Details Of Customer======");
            Console.WriteLine("Customer Name: " + CustomerName);
            Console.WriteLine("Account Number: " + AccountNo);
            Console.WriteLine("Account Type: " + AccountType);
            Console.WriteLine("Balance: Rs." + Balance);
        }
        static void Main()
        {
            Accounts test = new Accounts();
            test.ShowData();
            Console.ReadKey();
        }
    }
}