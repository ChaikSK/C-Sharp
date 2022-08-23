using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24__Getters_N_Setters
{
    class Program
    {
        static void Main(string[] args)
        {
            // object method is a method that we can define inside of our class that the objects of that class can 
            // use to either find out information or modify information about themselve. 
            Movies avengers = new Movies("Jin", "Business", "PG-13");
            Movies sherk = new Movies("Pam", "Art", "PG");

            sherk.Rating = "Cat";
            sherk.Rating = "R";

            Console.WriteLine(sherk.Rating);

            Console.ReadLine();
        }
    }
}
