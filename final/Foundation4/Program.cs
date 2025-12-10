using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running = new Running("04 Nov 2025", 20, 3.5f);
        activities.Add(running);

        Cycling cycling = new Cycling("07 Dec 2025", 50, 20);
        activities.Add(cycling);

        Swimming swimming = new Swimming("05 March 2026", 10, 15);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.getSummary());
        }
    }
}