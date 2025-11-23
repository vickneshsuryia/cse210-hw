
using System;
using System.Collections.Generic;
using System.IO;

class GoalManager
{
    //attributes
    private List<Goal> goals = new List<Goal>();
    private int _score = 0;

    //methods
    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }
    public void DisplayGoals()
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals created yet.");
            return;
        }

        int number = 1;
        foreach (Goal goal in goals)
        {
        Console.WriteLine(number + ". " + goal.DisplayStatus());
        number++;
        }
    }
    public void RecordEvent(int index)
    {
        if (index >= 0 && index < goals.Count)
        {
            _score += goals[index].RecordEvent();
            Console.WriteLine("Event recorded! New score: " + _score);
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }
    public int GetScore()
    {
        return _score;
    }

    public void SaveGoals(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved to " + fileName);
    }

    public void LoadGoals(string fileName)
    {
        if (File.Exists(fileName))
        {
            string[] lines = File.ReadAllLines(fileName);
            _score = int.Parse(lines[0]);
            goals.Clear();

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split("|");
                string type = parts[0];

                if (type == "SimpleGoal")
                {
                    goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4])));
                }
                else if (type == "EternalGoal")
                {
                    goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                }
                else if (type == "ChecklistGoal")
                {
                    goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6])));
                }
            }
            Console.WriteLine("Goals loaded from " + fileName);
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
