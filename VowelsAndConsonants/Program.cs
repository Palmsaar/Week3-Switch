using System;

namespace VowelsAndConsonants
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a letter!");
            char UserLetter = Convert.ToChar(Console.ReadLine().ToLower());
            switch (UserLetter)
            {
                case 'e':
                    Console.WriteLine("That is a vowel.");
                    break;
                case 'o':
                    Console.WriteLine("That is a vowel.");
                    break;
                case 'i':
                    Console.WriteLine("That is a vowel.");
                    break;
                case 'u':
                    Console.WriteLine("That is a vowel.");
                    break;
                /*case 'w':
                    Console.WriteLine("That is a vowel.");
                    break;
                case 'y':
                    Console.WriteLine("That is a vowel.");
                    break;*/
                default:
                    Console.WriteLine("That is a Consonant.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
