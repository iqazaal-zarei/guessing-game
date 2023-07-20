using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guessing_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string secretword = "qazal";
            string guess = "";
            int wordmax = 3;
            int wordcount = 0;
            bool outofguess = false;

            while (guess != secretword && !outofguess)
            {
                if (wordcount < wordmax)
                {
                    Console.WriteLine(" Entre secretword ");
                    guess = Console.ReadLine();
                    wordcount++;
                }
                else
                {
                    outofguess = true;
                }
            }
                if (outofguess)
                {
                    Console.WriteLine(" You lose :[ ");
                }
                else
                {
                    Console.WriteLine(" You win :] ");
                }
                Console.ReadLine();






            }
        }
    }
