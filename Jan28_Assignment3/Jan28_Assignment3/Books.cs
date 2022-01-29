using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan28_Assignment3
{
    internal class Information_Books
    {
        struct books
        {
            public string au,bn;

        }
        static void Main()
        {
            books[] books = new books[2];
            Console.WriteLine("Insert the Information of two Books:");
            Console.WriteLine("--------------------------------------------------------------------");
            for(int i=0;i<2;i++)
            {
                Console.WriteLine("Information of Book {0}:",i+1);
                Console.Write("Input name of the Book:");
                books[i].bn=Console.ReadLine();
                Console.Write("Input the author:");
                books[i].au=Console.ReadLine();
                Console.WriteLine();
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(i+1+": TITLE= {0},   Author= {1}",books[i].bn,books[i].au);
                Console.WriteLine();
            }
            Console.WriteLine("--------------------------------------------------------------------");
            Console.ReadKey();
        }
    }
}
