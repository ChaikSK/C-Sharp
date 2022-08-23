using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27__Inheritance
{
    class ItalianChef : Chef  // ItalianChef will inherite all the functionality from the normal Chef
    {
        public override void MakeSpecialDish()  // add virtual : can be override by other method
        {
            Console.WriteLine("The Chef makes chicken pams");
        }

        public void MakePasta()
        {
            Console.WriteLine("The Chef makes pasta");
        }

    }
}
