using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan25_Assignment2
{
    internal class Strings
    {
        static void Main()
        {
            Console.Write("Enter Word to Check Length:");
            string str=Console.ReadLine();
            Console.WriteLine("Length Of "+str+" is :"+str.Length);
            Console.WriteLine("Enter a Word to Reverse:");
            string str1=Console.ReadLine();
            Console.WriteLine("Reverse of of Word"+str1+" is: "+string.Join("",str1.Reverse()));
            Console.WriteLine("Enter Two Words to check both are same or not");
            string word1 = Console.ReadLine();
            string word2 = Console.ReadLine();
            if( word1==word2)
            {
                Console.WriteLine("Two Words are Equal");
            }
            else
            {
                Console.WriteLine("Two Words are not Equal");
            }
            Console.Read();
        }
    }
}
