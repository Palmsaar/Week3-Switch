using System;

namespace InstragramAgeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What year were you born?");
            int UserYear = Int32.Parse(Console.ReadLine());
            int UserAge = 2021 - UserYear;
            if (UserAge >= 13)
            {
                Console.WriteLine("You are old enough to Make an account.");
            }
            else
            {
                Console.WriteLine("You are not old enough to make an account.");
            }
            Console.ReadLine();
        }
    }
}
