using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15__While_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //while loop
            int index = 1;
            while (index <= 5)
            {
                Console.WriteLine(index);
                index++;
            }

            //do while loop
            int index2 = 1;
            do
            {
                Console.WriteLine(index);
                index2++;
            } while (index2 <= 5);


            Console.ReadLine();
        }


    }
}
