using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11__if_statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isMale = true;
            bool isTall = false;

            if (isMale && isTall)
            {
                Console.WriteLine("You are a tall male");
            } 
            else if ( isMale && !isTall)
            {
                Console.WriteLine("You are a short male");
            }
            else if (!isMale && isTall)
            {
                Console.WriteLine("You are not a male but tall");
            }
            else 
            {
                Console.WriteLine("You are either not male or not tall");
            }
            Console.ReadLine();
        }
    }
}
