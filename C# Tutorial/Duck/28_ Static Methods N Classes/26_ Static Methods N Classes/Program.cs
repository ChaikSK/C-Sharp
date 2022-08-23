using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26__Static_Methods_N_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // static method is a class belong to the actual class, dun need object to use it or access it  
            // UsefulTools tools = new UsefulTools();
            UsefulTools.SayHi("Great");

            Console.ReadLine();
        }
    }
}
