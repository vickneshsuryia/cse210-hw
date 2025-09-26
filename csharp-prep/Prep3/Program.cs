using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,101);
        while (true)
        { 
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            int numberGuess = int.Parse(guess);
                if (number == numberGuess)
                {
                    Console.WriteLine("You're correct!");
                    break;
                }
                else if (number > numberGuess)
                {
                    Console.WriteLine("Higher!");
                }
                else
                {
                    Console.WriteLine("Lower!");
                }
        }
    }
}