using System;
using System.Threading;

public class Activity
{
    //attributes
    protected int _duration;
    private string _name;
    private string _description;

    //constructor
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    //methods
    public void SetTime()
    {
        Console.Write("How long, in seconds, would you like your session to be? ");
        _duration = int.Parse(Console.ReadLine());
    }
    public void Spinner()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(3);
        while (DateTime.Now < futureTime)
        {
            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b \b");

            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");

            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");

            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }
    public void Pause(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {
            Spinner();
        }
    }
    public void WelcomeMsg()
    {
        Console.WriteLine($"\nWelcome to the {_name}!\n");
    }
    public void Description()
    {
        Console.WriteLine($"{_description}\n");
    }
    public void EndMsg()
    {
        Console.WriteLine("\nWell done!");
        Console.WriteLine($"You have completed {_duration} seconds of {_name} activity.\n");
        Spinner();
    }
    public int GetDuration()
    {
        return _duration;
    }
}