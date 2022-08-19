using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18__Building_an_Exponent_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exponent Function can pass in two numbers (base number and power number) and take base number to power number
            // Eg, 2,3 -> 2^3 or 4,7 -> 4^7

            Console.WriteLine(GetPow(3, 2));

            Console.ReadLine();

        }

        static int GetPow(int baseNum, int powNum)
        {
            int result = 1;

            for (int i = 0; i < powNum; i++)
            {
                result *= baseNum;
            }

            return result;
        }
    }
}
