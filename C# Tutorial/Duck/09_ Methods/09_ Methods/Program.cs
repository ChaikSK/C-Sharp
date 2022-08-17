using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09__Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Method is block of code to perform a specific task

            // call method
            SayHi();

            // call method with parameter
            SayHi2("Mike");
            SayHi2("John");
            SayHi2("Tom");

            // call method with parameters
            SayHi3("Mike", 30);
 
            Console.ReadLine();
        }

        // method
        static void SayHi()
        {
            Console.WriteLine( "Hello User" );
        }

        // method with parameter
        static void SayHi2(string name)
        {
            Console.WriteLine( "Hello " + name );
        }

        // method with parameters
        static void SayHi3(string name, int age)
        {
            Console.WriteLine("Hello " + name + " ,you are " + age);
        }
    }
}
