using System;

namespace ControlFlow_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, ender a PIN");
            int UserPIN = Int32.Parse(Console.ReadLine());
            int DefaultPIN = 1234;
            
            /*if (UserPIN == DefaultPIN)
            {
                Console.WriteLine("Welcome!");
            }
            else //if (UserPIN != DefaultPIN)
            {
                Console.WriteLine("Wrong PIN, Try again!");
            }*/

            Console.ReadLine();
        }
    }
}
