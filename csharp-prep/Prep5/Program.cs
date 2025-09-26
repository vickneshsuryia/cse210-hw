using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();

        string name = PromptUserName();
        int number = PromptUserNumber();

        PromptUserBirthYear(out int birthYear);

        DisplayResult(name, SquareNumber(number), birthYear);
    }

    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static void PromptUserBirthYear(out int birthYear)
    {
        Console.Write("Please enter your birth year: ");
        birthYear = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int x)
    {
        int square = x * x;
        return square;
    }
    
    static void DisplayResult(string name, int square, int birthYear)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
        int age = 2025 - birthYear;
        Console.WriteLine($"{name}, your age is {age}.");
    }
}