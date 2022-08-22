using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23__Object_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // object method is a method that we can define inside of our class that the objects of that class can 
            // use to either find out information or modify information about themselve. 
            Student student1 = new Student("Jin", "Business", 2.8);
            Student student2 = new Student("Pam", "Art", 3.8);

            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());

            Console.ReadLine();
        }
    }
}
