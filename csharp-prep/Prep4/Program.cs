using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int sum = 0;
        int number = -1;
        int largest = -1;

        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        }

        foreach (int integer in numbers)
        {
            sum += integer;
            if (integer > largest)
            {
                largest = integer;
            }
        }

        Console.WriteLine($"The sum is: {sum}.");
        int average = sum / (numbers.Count - 1);
        Console.WriteLine($"The average is: {average}.");
        Console.WriteLine($"The largest number is: {largest}.");
    }
}