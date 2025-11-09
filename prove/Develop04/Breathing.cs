using System;

public class Breathing : Activity
{
    //methods
    public Breathing() : base("Breathing Activity", 
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {}
    public void Run()
    {
        Console.Clear();
        WelcomeMsg();
        Description();
        SetTime();
        Console.Clear();
        Console.WriteLine("Prepare to begin...");
        Spinner();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            Pause(3);
            Console.WriteLine();

            Console.Write("Breathe out...");
            Pause(3);
            Console.WriteLine();
        }

        EndMsg();
    }
}