using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan28_Assignment3
{
    struct Books
    {
        private int Book_id;
        public int id
        {
            get { return Book_id; }
            set { Book_id = value; }
        }
        //taking two more values for better understanding purpose
        private string Book_name;
        public string name
        {
            get { return Book_name; }
            set { Book_name = value; }
        }
        private float Book_price { get; set; }
        public float price
        {
            get { return Book_price; }
            set { Book_price = value; }
        }
        //method to display values
        public void Display()
        {
            Console.WriteLine("Book id is: "+Book_id);
            Console.WriteLine("Name of the Book: "+Book_name);
            Console.WriteLine("Price of the Book: Rs."+ Book_price);
        }

    };

    internal class Structure
    {
        
        static void Main()
        {
            Books books = new Books();
            books.id = 467;
            books.name = "Core Java";
            books.price = 572.76f;
            books.Display();
            Console.ReadKey();
        }
        
    }
}
