using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17___For_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] luckyNumbers = { 4, 8, 5, 2, 7, 20 };

            for ( int i = 0; i < luckyNumbers.Length; i++)
            {
                Console.WriteLine(luckyNumbers[i]);
            }
            Console.ReadLine();
        }
    }
}
