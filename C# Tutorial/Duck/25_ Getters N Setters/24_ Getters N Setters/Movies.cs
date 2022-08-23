using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24__Getters_N_Setters
{
    class Movies
    {
        public string name;
        public string director;
        private string rating;

    public Movies(string aName, string aDirector, string aRating)
    {
        name = aName;
        director = aDirector;
        Rating = aRating;  // call the set
    }

    public string Rating
    {
        get { return rating; } // get the rating attribute
        set {  
             if (value == "G" || value == "PG" || value == "G" || value == "R" || value == "G")
             {
                rating = value;
             } else
             {
                rating = "NR";
             }       
        } // set and modify the rating 
    }

    }
}
