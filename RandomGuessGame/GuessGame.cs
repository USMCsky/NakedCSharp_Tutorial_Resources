using System;
using System.Collections.Generic;
using System.Text;
using static System.Math;

public class GuessGame
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        bool playAgain = true;

        while (playAgain)
        {
            int number = rand.Next(1, 101);
            int guess = 0;

            Console.Clear();

            Console.WriteLine("What number am I thinking of?");

            while (!int.TryParse(Console.ReadLine(), out guess))
            {
                Console.WriteLine("Please enter a valid number:");
            }

            while (guess != number)
            {
                Console.WriteLine("Sorry! Let's try that again");
                if (guess < number)
                {
                    Console.WriteLine("TOO LOW - Try again.");
                }
                else
                {
                    Console.WriteLine("TOO HIGH - Try again.");
                }

                while (!int.TryParse(Console.ReadLine(), out guess))
                {
                    Console.WriteLine("Please enter a valid number:");
                }
            }

            Console.WriteLine("CONGRATULATIONS  " + number + " is the magic number!");

            Console.Write("Play again? (Y/N): ");
            var response = Console.ReadLine();
            if (string.IsNullOrEmpty(response) || !response.Trim().StartsWith("y", StringComparison.OrdinalIgnoreCase))
            {
                playAgain = false;
            }
        }
    }
}
