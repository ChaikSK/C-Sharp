using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23__Object_Methods
{
    class Student
    {
        public string name;
        public string major;
        public double gpa;

        public Student (string aName, string aMajor, double aGpa) //constructor
        {
            name = aName;
            major = aMajor;
            gpa = aGpa;
        }

        // method to check whether student with honors/ without honors 
        public bool HasHonors()
        {
            if (gpa >= 2.5)
            {
                return true;
            }
            return false;
        }
    }
}
