using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your test score? ");
        string score = Console.ReadLine();
        int grade = int.Parse(score);
        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else if (grade < 60)
        {
            letter = "F";
        }


        Console.WriteLine($"This is your grade: {letter}.");
        
        if (letter == "D" || letter == "F")
        {
            Console.WriteLine("You unfortunately did not pass the test. Try again next time!");
        }
        else
        {
            Console.WriteLine("Congratulations! You passed!");
        }
    }
}