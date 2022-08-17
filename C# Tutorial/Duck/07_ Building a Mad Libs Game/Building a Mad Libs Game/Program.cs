using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building_a_Mad_Libs_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string color, pluralNoun, celebrity;
            Console.Write("Enter color: ");
            color = Console.ReadLine();

            Console.Write("Enter pluralNoun: ");
            pluralNoun = Console.ReadLine();

            Console.Write("Enter celebrity: ");
            celebrity = Console.ReadLine();

            Console.WriteLine("Rose are " + color);
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("I Love " + celebrity);

            Console.ReadLine();
        }
    }
}
