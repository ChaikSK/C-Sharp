using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a book object. Object is instance of a class
            Book book = new Book();
            Book book1 = new Book("Harry Potter", "JK", 400); // directly link to the contructor book ( public book() )
            Book book2 = new Book("Loard of the Rings", "Tolkein", 800);

            book2.title = "Hobit";

            Console.WriteLine(book1.title);
            Console.WriteLine(book2.title);

            Console.ReadLine();
        }
    }
}
