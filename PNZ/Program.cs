using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the game!");

        Console.WriteLine("Game rules: Guess the number between 1 and 100.");

        int numberToGuess = new Random().Next(1, 101);
        int playerNumber;
        int attemptsCount = 0;

        while (true)
        {
            Console.Write("Enter your guess: ");

            if (int.TryParse(Console.ReadLine(), out playerNumber))
            {
                attemptsCount++;

                if (playerNumber == numberToGuess)
                {
                    Console.WriteLine($"Congratulations! You guessed the number {numberToGuess} in {attemptsCount} attempts.");
                    break;
                }
                else if (playerNumber < numberToGuess)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else
                {
                    Console.WriteLine("Too high! Try again.");
                }
            }
            else
            {
                Console.WriteLine("That's not a number! Try again.");
            }
        }

        Console.WriteLine("Game over!");

        ThankYou();

        Console.ReadLine();
    }

    static void ThankYou()
    {
        Console.WriteLine("Thank you for playing!");
    }
}

