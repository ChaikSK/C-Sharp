using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06__Building_a_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // convert String to Integer
            int num = Convert.ToInt32("45"); 
            Console.WriteLine( num + 6 );

            Console.Write("Enter a number: ");  // get string
            int num1 = Convert.ToInt32(Console.ReadLine()); // Convert to integer 

            Console.Write("Enter a another number: ");  // get string
            int num2 = Convert.ToInt32(Console.ReadLine()); // Convert to integer 

            Console.WriteLine( num1 + num2 );
            Console.ReadLine();
        }
    }
}
