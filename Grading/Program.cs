using System;

namespace Grading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What grade did you get? (in numbers)");
            int UserGrade = Int32.Parse(Console.ReadLine());
           switch (UserGrade)
            {
                case 5:
                    Console.WriteLine("Excellent!");
                    break;
                case 4:
                    Console.WriteLine("Very good!");
                    break;
                case 3:
                    Console.WriteLine("Good.");
                    break;
                case 2:
                    Console.WriteLine("satisfactory.");
                    break;
                case 1:
                    Console.WriteLine("inadequate.");
                    break;
                default:
                    Console.WriteLine("Repeate the course.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
