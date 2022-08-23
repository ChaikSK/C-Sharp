using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26__Static_Class_Attributes
{
    // Static attribute is about the actual class
    class Song
    {
        public string title;
        public string artist;
        public int duration;
        public static int songCount = 0;

        public Song(string aTitle, string aArtist, int aDuration) // constructor
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            songCount++;
        }   

        public int getSongCount()
        {
            return songCount;
        }
    }
}
