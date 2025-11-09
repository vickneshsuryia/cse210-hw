using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";

        //as part of the creativity requirement, I created a counter for the user to see how many activities they have completed throughout a session
        int breathingCount = 0;
        int reflectingCount = 0;
        int listingCount = 0;

        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Mindfulness App");
            Console.WriteLine("------------------------");
            Console.WriteLine("Menu options:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select an option: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                breathingCount++;
                Breathing breathing = new Breathing();
                breathing.Run();
            }
            else if (choice == "2")
            {
                reflectingCount++;
                Reflecting reflecting = new Reflecting();
                reflecting.Run();
            }
            else if (choice == "3")
            {
                listingCount++;
                Listing listing = new Listing();
                listing.Run();
            }
            else if (choice == "4")
            {
                Console.WriteLine("\nSession Summary:");
                Console.WriteLine($"Breathing activities completed: {breathingCount}");
                Console.WriteLine($"Reflecting activities completed: {reflectingCount}");
                Console.WriteLine($"Listing activities completed: {listingCount}");
                Console.WriteLine("\nGoodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Try again.");
            }

            if (choice != "4")
            {
                Console.WriteLine("\nPress Enter to return to the menu...");
                Console.ReadLine();
            }
        }
    }
}