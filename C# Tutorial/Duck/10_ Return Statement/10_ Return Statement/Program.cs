using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10__Return_Statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Retrun value back to value 
            int cubedNumber = cube(5);
            Console.WriteLine(cubedNumber); 
            Console.WriteLine(cube(5));
            Console.ReadLine();
        }

        // method with return value
        static int cube(int num)
        {
            int result = num * num * num;
            return result;
        }

    }
}
