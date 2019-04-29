using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneOnePigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            int wave = 0;
            wave++;
            while (wave == 1)
            {
                Console.WriteLine("Welcome to the Pig Latin Translator!\nWhat would you like translated?:");
                string Translate = Console.ReadLine().ToLower();
                Console.WriteLine(Guinea.Aye(Translate));
                Console.WriteLine("Continue? Yes or No");
                wave++;
                string answer5 = null;
                answer5 = Console.ReadLine();
                if (answer5 == "Yes")
                {
                    wave--;
                }
                if (answer5 == "No")
                {
                    Console.WriteLine("Hope You Have A Good Day!");
                }

            }


        }
    }
}

     
