using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working_with_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "Duck Academy" + " is cool"; // concatenation 
            Console.WriteLine(phrase);
            Console.WriteLine(phrase.Length);   // character numbers
            Console.WriteLine(phrase.ToUpper());    // Convert to Uppercase
            Console.WriteLine(phrase.Contains("Academy"));  // find string contains same string character
            Console.WriteLine(phrase[0]);   // print first character of the string
            Console.WriteLine(phrase[2]);   // print third character of the string
            Console.WriteLine(phrase.IndexOf("Academy"));   // index position stored inside a string
            Console.WriteLine(phrase.IndexOf("k"));   // index position stored inside a string
            Console.WriteLine(phrase.IndexOf("p"));   // return -1 : indicate character not inside the string
            Console.WriteLine(phrase.Substring(5));   //  grab the character 
            Console.WriteLine(phrase.Substring(5,10));   //  grab the character 

            Console.ReadLine();
        }
    }
}
