using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Book  // create a complex datatype - composed all other dataype
    {
        // class attributes
        public string title;
        public string author;
        public int pages;

        public Book()  // Constructor : special method in our class,
                                                                // thats going to get called when we create an object of this class.
        {
            Console.WriteLine("Test---");
        }

        public Book(string aTitle, string aAuthor, int aPages)  // Constructor : special method in our class,
                                                                // thats going to get called when we create an object of this class.
        {
            title = aTitle; // assign parameter to the object attributes
            author = aAuthor;
            pages = aPages;
        }
    }
}
