using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27__Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Chef chef = new Chef();
            chef.MakeChicken();

            ItalianChef italianChef = new ItalianChef();
            italianChef.MakeChicken();
            italianChef.MakePasta();

            Console.ReadLine();
        }
    }
}
