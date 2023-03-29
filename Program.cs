using System;

namespace NumberGuesser
{
    class Program
    {
        static int lowerBound = 1;
        static int upperBound = 1024;
        static int guess = 512;
        static void TakingAGuess()
        {
            Console.WriteLine($"My guess is {guess}. Is your number (H)IGHER, (L)OWER, or am I (C)ORRECT?");
            var userInput = Console.ReadLine().ToLower();
            if (userInput == "h")
            {
                ComputeNewHighIfTooHigh();
            }
            else if (userInput == "l")
            {
                ComputeNewLowIfTooLow();
            }
            else if (userInput == "c")
            {
                BragWhenCorrect();
            }
            else
            {
                Console.WriteLine("Please enter a valid response.");
            }
        }
        static void ShowGreeting()
        {
            Console.WriteLine("Greetings! I am the amazing Number Guesser!");
            Console.WriteLine("Please think of, BUT DO NOT TELL ME, a number between 1 and 1024.");
            Console.WriteLine("Using my amazing computing power I will figure out your number by asking you questions");
        }
        static void ComputeNewLowIfTooLow()
        {
            Console.WriteLine("Ok, lower.");
            upperBound = guess;
            guess = (upperBound + lowerBound) / 2;
            TakingAGuess();
        }
        static void ComputeNewHighIfTooHigh()
        {
            Console.WriteLine("Ok, higher.");
            lowerBound = guess;
            guess = (upperBound + lowerBound) / 2;
            TakingAGuess();
        }
        static void BragWhenCorrect()
        {
            Console.WriteLine("There we go! Told ya so!");
        }
        static void Main(string[] args)
        {
            ShowGreeting();
            TakingAGuess();


        }
    }
}
