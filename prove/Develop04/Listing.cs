using System;
using System.Collections.Generic;

public class Listing : Activity
{
    //attributes
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    //constructor
    public Listing() : base("Listing Activity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }
    //method
    public void Run()
    {
        Console.Clear();
        WelcomeMsg();
        Description();
        SetTime();
        Console.Clear();
        Console.WriteLine("Prepare to begin...");
        Spinner();

        Random rand = new Random();
        Console.WriteLine(_prompts[rand.Next(_prompts.Count)]);
        Console.WriteLine("You may begin listing in a moment...");
        Pause(3);

        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("Enter: ");
            string input = Console.ReadLine();
            items.Add(input);
        }

        Console.WriteLine($"\nYou listed {items.Count} items!");
        EndMsg();
    }
}
