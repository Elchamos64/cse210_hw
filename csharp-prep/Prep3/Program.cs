using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Welcome to the magic number game! Guess a number between 1 and 100! ");

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        int guess = 1;

        while ( guess != magicNumber)
        {
            Console.Write("What is your guess ");
            guess = int.Parse(Console.ReadLine());

            if (guess > magicNumber)
            {
                Console.WriteLine("Too high!");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Too low");
            }
            else
            {
                Console.WriteLine($"You got it right! The answer was " +magicNumber );
            }
        }
    }
}