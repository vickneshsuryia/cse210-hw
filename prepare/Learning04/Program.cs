using System;

class Program
{
    static void Main(string[] args)
    {
        WritingAssignment assignment1 = new WritingAssignment("John Wick", "French History", "The Causes of World War II");
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine(assignment1.GetWritingInformation());

        MathAssignment assignment2 = new MathAssignment("Bella Swan", "Algebra", "7.3", "1-9");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());

        Assignment assignment3 = new Assignment("Jane Doe", "Literature");
        Console.WriteLine(assignment3.GetSummary());
    }
}