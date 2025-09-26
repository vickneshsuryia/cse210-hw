using System;
using System.Globalization;


class Program
{
    static void Main(string[] args)
    {
        string capitalizeAttempt = "hello sandbox world!!!!!!!";
        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        string capitalized = textInfo.ToTitleCase(capitalizeAttempt);
        Console.WriteLine(capitalized);
    }
}