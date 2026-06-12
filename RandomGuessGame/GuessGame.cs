using System;

public class GuessGame
{
    static void Main(string[] args)
    {
        var rand = new Random();

        do
        {
            PlayOneRound(rand);
        }
        while (AskToPlayAgain());
    }

    static void PlayOneRound(Random rand)
    {
        int secret = rand.Next(1, 101);
        int attempts = 0;

        Console.Clear();
        Console.WriteLine("I'm thinking of a number between 1 and 100.");

        while (true)
        {
            int guess = ReadIntFromConsole("Your guess: ");
            attempts++;

            if (guess == secret)
            {
                Console.WriteLine($"CONGRATULATIONS — {secret} is correct! You guessed it in {attempts} attempt{(attempts == 1 ? "" : "s") }.");
                break;
            }

            Console.WriteLine(guess < secret ? "TOO LOW - try again." : "TOO HIGH - try again.");
        }
    }

    static int ReadIntFromConsole(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            var input = Console.ReadLine();
            if (int.TryParse(input, out var value))
                return value;

            Console.WriteLine("Please enter a valid number.");
        }
    }

    static bool AskToPlayAgain()
    {
        Console.Write("Play again? (Y/N): ");
        var response = Console.ReadLine();
        return !string.IsNullOrEmpty(response) && response.Trim().StartsWith("y", StringComparison.OrdinalIgnoreCase);
    }
}
