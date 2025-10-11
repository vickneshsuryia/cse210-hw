using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the journal program!");
        Startmenu myStartmenu = new Startmenu();
        Journal myJournal = new Journal();

        string choice = "";
        while (choice != "Q")
        {
            Console.WriteLine("Please select one of the following choices:");
            myStartmenu.Display();
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            if (choice == "W")
            {
                List<string> prompts = new List<string>
                {
                    "Who was the most interesting person I interacted with today?",
                    "What was the best part of my day?",
                    "How did I see the hand of the Lord in my life today?",
                    "What was the strongest emotion I felt today?",
                    "If I had one thing I could do over today, what would it be?",
                    "How was I productive today?",
                    "What was something I wish could have done today?",
                    "How did I fulfill my dreams today?"
                };

                Random rand = new Random();
                string selectedPrompt = prompts[rand.Next(prompts.Count)];

                Console.WriteLine(selectedPrompt);
                Console.Write("> ");
                string response = Console.ReadLine();

                Entry newEntry = new Entry();
                newEntry.Prompt = selectedPrompt;
                newEntry.Response = response;
                newEntry.Date = DateTime.Now.ToShortDateString();

                myJournal.AddEntry(newEntry);
            }
            else if (choice == "D")
            {
                myJournal.DisplayAll();
            }
            else if (choice == "L")
            {
                Console.Write("Enter filename to load: ");
                string filename = Console.ReadLine();
                myJournal.LoadFromFile(filename);
            }
            else if (choice == "S")
            {
                Console.Write("Enter filename to save: ");
                string filename = Console.ReadLine();
                myJournal.SaveToFile(filename);
            }
            else if (choice == "Q") 
            {
                Console.WriteLine("Exiting program.");
            }
            else
            {
                Console.WriteLine("Invalid choice, try again.");
            }
        }
    }
}
