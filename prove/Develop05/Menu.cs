
using System;

class Menu
{
    //attributes
    private GoalManager manager = new GoalManager();
    //methods
    public void Show()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Quit");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                CreateGoal();
            }
            else if (choice == "2")
            {
                manager.DisplayGoals();
            }
            else if (choice == "3")
            {
                RecordEvent();
            }
            else if (choice == "4")
            {
                Console.WriteLine("Score: " + manager.GetScore());
            }
            else if (choice == "5")
            {
                Console.Write("Enter filename to save (e.g., mygoals.txt): ");
                string saveFile = Console.ReadLine();
                manager.SaveGoals(saveFile);
            }
            else if (choice == "6")
            {
                Console.Write("Enter filename to load (e.g., mygoals.txt): ");
                string loadFile = Console.ReadLine();
                manager.LoadGoals(loadFile);
            }
            else if (choice == "7")
            {
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid choice. Try again.");
            }
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("Choose type of goal: 1 - Simple, 2 - Eternal, 3 - Checklist");
        string type = Console.ReadLine();

        Console.Write("Name of goal: ");
        string name = Console.ReadLine();

        Console.Write("Description of goal: ");
        string desc = Console.ReadLine();

        Console.Write("Points (when completed): ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            manager.AddGoal(new SimpleGoal(name, desc, points));
        }
        else if (type == "2")
        {
            manager.AddGoal(new EternalGoal(name, desc, points));
        }
        else if (type == "3")
        {
            Console.Write("Target Count: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Bonus Points (when completed): ");
            int bonus = int.Parse(Console.ReadLine());

            manager.AddGoal(new ChecklistGoal(name, desc, points, target, bonus));
        }
        else
        {
            Console.WriteLine("Invalid type.");
        }
    }

    private void RecordEvent()
    {
        manager.DisplayGoals();
        Console.Write("Select goal number: ");
        int index = int.Parse(Console.ReadLine()) - 1;
        manager.RecordEvent(index);
    }
}
