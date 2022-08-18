using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16__Building_a_Guessing_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "duck";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false; // if the user out of guess

            while (guess != secretWord && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                } else
                {
                    outOfGuesses = true;
                }              
            }

            if (outOfGuesses)
            {
                Console.Write("You Lose!");
            }
            else
            {
                Console.Write("You Win!");
            }

            Console.ReadLine();
        }
    }
}
