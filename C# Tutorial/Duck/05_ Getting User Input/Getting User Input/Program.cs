using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getting_User_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: "); // write same line
            string name = Console.ReadLine();   // stored in name variable

            Console.Write("Enter your age: "); // write same line
            string age = Console.ReadLine();   // stored in age variable

            Console.WriteLine("Hello " + name + ", your age is " + age);

            Console.ReadLine();
        }
    }
}
