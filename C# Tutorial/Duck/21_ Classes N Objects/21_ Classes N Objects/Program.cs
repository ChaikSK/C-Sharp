using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21__Classes_N_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create a book object. Object is instance of a class
            Book book1 = new Book(); // create actual book object 
            book1.title = "Harry Potter";
            book1.author = "JK";
            book1.pages = 400;

            Book book2 = new Book(); // create actual book object 
            book2.title = "Loard of the Rings";
            book2.author = "Tolkein";
            book2.pages = 800;

            Console.WriteLine(book1.title);
            Console.WriteLine(book2.title);

            Console.ReadLine();
        }
    }
}
