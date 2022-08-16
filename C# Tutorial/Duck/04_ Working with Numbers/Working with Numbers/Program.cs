using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working_with_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 6;
            num++;  // add one to the number
            num--;  

            Console.WriteLine( 5 + 8 ); // Add
            Console.WriteLine( 5 - 8 ); // Substrac
            Console.WriteLine( 5 * 8 ); // Mutiply
            Console.WriteLine( 5 / 8 ); // Devide
            Console.WriteLine( 5 % 8 ); // Modular
            Console.WriteLine( (5 + 8) * 3 );
            Console.WriteLine( 5 + 8.1 );   // any math calculation with decimal return decimal
            Console.WriteLine( 5 / 2.0 );
            Console.WriteLine( num );

            Console.WriteLine( Math.Abs(-40) );
            Console.WriteLine( Math.Pow(3, 2) );
            Console.WriteLine(Math.Max(10, 2));
            Console.WriteLine(Math.Min(10, 2));
            Console.WriteLine(Math.Round(4.7));

            Console.ReadLine();
        }
    }
}
