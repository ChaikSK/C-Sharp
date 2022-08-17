using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08__Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] luckyNumbers = { 4, 8, 10, 15, 16, 29 };
            string[] friends = new string[5]; // empty array: tell c# hw many arrays to hold
            friends[0] = "Jim";
            friends[1] = "Kelly";

            // change array element
            luckyNumbers[1] = 900;

            Console.WriteLine( luckyNumbers[1] );

            Console.ReadLine();
        }
    }
}
