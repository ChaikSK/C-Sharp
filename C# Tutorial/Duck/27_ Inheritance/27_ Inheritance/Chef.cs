using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27__Inheritance
{
    class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("The Chef makes chicken");
        }

        public void MakeSalad()
        {
            Console.WriteLine("The Chef makes sald");
        }

        public virtual void MakeSpecialDish()  // add virtual : can be override by other method
        {
            Console.WriteLine("The Chef makes bbq ribs");
        }
    }
}
