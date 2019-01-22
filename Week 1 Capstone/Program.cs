using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Week_1_Capstone
{
    class Program
    {
        private static void Main(string[] args)
        {
            bool repeat1 = true;
            while (repeat1 == true)
            {
                Console.WriteLine("Welcome to the Pig Latin Translator!");
                Console.WriteLine("Enter a Line to be translated:");

                string input = (Console.ReadLine());
                char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
                int index = input.ToLower().IndexOfAny(vowels);

                string restOfWord = input.Substring(index);
                string firstLetters = input.Substring(0, index);

                if (index == 0)
                {
                    input += "way";
                    Console.WriteLine(input);
                }
                else if (index != 0)
                {
                    Console.WriteLine($"{restOfWord}{firstLetters}{"ay"}");
                }
                repeat1 = Continue();
            }
        }
        public static bool Continue()
        {
            Console.WriteLine("Would you like to translate another line?");
            string again = Console.ReadLine().ToLower();
            bool repeat = true;

            if (again == "y")
            {
                repeat = true;
            }
            else if (again == "n")
            {
                Console.WriteLine("Thank you for playing, Goodbye!");
                repeat = false;
            }
            else
            {
                Console.WriteLine("Invalid input! Please try again");
                repeat = Continue();
            }
            return repeat;            
        }
    }
}
