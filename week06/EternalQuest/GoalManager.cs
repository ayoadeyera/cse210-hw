using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void Start()
    {
        string choice = "";
        while (choice != "6")
        {
            DisplayPlayerInfo();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1") CreateGoal();
            else if (choice == "2") ListGoalDetails();
            else if (choice == "3") SaveGoals();
            else if (choice == "4") LoadGoals();
            else if (choice == "5") RecordEvent();
        }
    }

    public void DisplayPlayerInfo()
    {
        // Exceeding Requirements: Leveling System
        int level = (_score / 1000) + 1;
        string rank = level switch
        {
            1 => "Novice",
            2 => "Apprentice",
            3 => "Squire",
            4 => "Knight",
            5 => "Champion",
            _ => "Legendary Hero"
        };

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"\n--- {rank} (Level {level}) ---");
        Console.ResetColor();
        Console.WriteLine($"Total Score: {_score} points\n");
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.WriteLine("  4. Negative Goal (Bad Habit)");
        Console.Write("Which type of goal would you like to create? ");
        string type = Console.ReadLine();

        if (type == "4")
        {
            Console.Write("What bad habit are you trying to avoid? ");
            string name = Console.ReadLine();
            Console.Write("Describe why you want to stop this: ");
            string desc = Console.ReadLine();
            Console.Write("How many points should be LOST for each slip-up? ");
            int points = int.Parse(Console.ReadLine());
            _goals.Add(new NegativeGoal(name, desc, points));
            return;
        }

        Console.Write("What is the name of your goal? ");
        string nameInput = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int pointsInput = int.Parse(Console.ReadLine());

        if (type == "1") _goals.Add(new SimpleGoal(nameInput, description, pointsInput));
        else if (type == "2") _goals.Add(new EternalGoal(nameInput, description, pointsInput));
        else if (type == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(nameInput, description, pointsInput, target, bonus));
        }
    }

    public void RecordEvent()
    {
        ListGoalDetails();
        Console.Write("Which goal did you accomplish/slip on? ");
        int index = int.Parse(Console.ReadLine()) - 1;

        Goal goal = _goals[index];
        goal.RecordEvent();
        
        int change = goal.GetPoints();

        // Exceeding Requirements: Negative Goal Logic and Color UI
        if (goal is NegativeGoal)
        {
            _score -= change;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n[!] Slip-up recorded. You lost {change} points.");
        }
        else
        {
            if (goal is ChecklistGoal checklist && goal.IsComplete())
            {
                change += checklist.GetBonus();
            }
            _score += change;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n[+] Congratulations! You earned {change} points!");
        }
        Console.ResetColor();
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        if (!File.Exists(fileName)) return;

        string[] lines = File.ReadAllLines(fileName);
        _score = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(':');
            string type = parts[0];
            string[] details = parts[1].Split(',');

            if (type == "SimpleGoal")
                _goals.Add(new SimpleGoal(details[0], details[1], int.Parse(details[2]), bool.Parse(details[3])));
            else if (type == "EternalGoal")
                _goals.Add(new EternalGoal(details[0], details[1], int.Parse(details[2])));
            else if (type == "ChecklistGoal")
                _goals.Add(new ChecklistGoal(details[0], details[1], int.Parse(details[2]), int.Parse(details[3]), int.Parse(details[4]), int.Parse(details[5])));
            else if (type == "NegativeGoal")
                _goals.Add(new NegativeGoal(details[0], details[1], int.Parse(details[2])));
        }
    }
}