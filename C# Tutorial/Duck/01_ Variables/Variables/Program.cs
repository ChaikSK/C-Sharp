using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables : like container store diff type of data values
            string characterName = "John";
            int characterAge;   // declaring variable
            characterAge = 35;  // assign value to variable
            Console.WriteLine("There once was a man named " + characterName); // concate 
            Console.WriteLine("He was " + characterAge + " years old");
            Console.WriteLine("He really liked the name " + characterName);
            Console.WriteLine("But didn't like being " + characterAge);

            Console.ReadLine();
        }
    }
}
