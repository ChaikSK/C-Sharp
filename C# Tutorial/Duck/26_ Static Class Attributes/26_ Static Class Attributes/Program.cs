using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26__Static_Class_Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Song holiday = new Song("Holiday", "Green Day", 200);
            Console.WriteLine(Song.songCount); // static attributes: public static int songCount = 0;

            Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);
            Console.WriteLine(Song.songCount); // static attributes: public static int songCount = 0;

            Console.WriteLine(kashmir.artist);
            Console.WriteLine(kashmir.getSongCount());

            Console.ReadLine();
        }
    }
}
