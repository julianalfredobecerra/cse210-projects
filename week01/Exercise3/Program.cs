using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Random randomGenerator = new Random();
        string keepPlaying = "yes";

        while (keepPlaying.ToLower() == "yes")
        // ToLower() ensures the input is case-insensitive.
        {
            int magicNumber = randomGenerator.Next(1, 100);
            int guessCount = 0;
            int guess = -1;

            Console.WriteLine("Welcome to the Magic Number Game!");

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out guess))
                {
                    guessCount++;

                    if (guess < magicNumber)
                    {
                        Console.WriteLine("Higher");
                    }

                    else if (guess > magicNumber)
                    {
                        Console.WriteLine("Lower");
                    }

                    else
                    {
                        Console.WriteLine("You guessed it!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }

            Console.WriteLine($"It took you {guessCount} guesses.");
            Console.Write("Would you like to play again (yes/no)? ");
            keepPlaying = Console.ReadLine();
        }

        Console.WriteLine("Thank you for playing. Goodbye.");
    }
}