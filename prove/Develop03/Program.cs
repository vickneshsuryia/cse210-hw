using System;

class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();

        List<Scripture> scriptures = new List<Scripture>();

        scriptures.Add(new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son"));
        scriptures.Add(new Scripture(new Reference("Philippians", 4, 13), "I can do all things through Christ who strengthens me"));
        scriptures.Add(new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight"));

        int index = rand.Next(scriptures.Count);

        Scripture currentScripture = scriptures[index];

        currentScripture.Display();

        while (!currentScripture.IsHidden())
        {
            Console.WriteLine("\nPress Enter to hide some words, or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input == "quit")
                break;

            currentScripture.HideWords();
            Console.Clear();
            currentScripture.Display();
        }
    }
}