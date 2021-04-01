using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            while (!command.Equals("End"))
            {
                Console.WriteLine("In while loop");
                command = Console.ReadLine();
            }

            Console.WriteLine("Out of while");
        }
    }
}
