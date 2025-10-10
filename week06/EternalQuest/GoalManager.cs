using System;
using System.Collections.Generic;
using System.IO;
//using System.Xml.Serialization; //This auto filled...I love when that happens and I don't notice. Notating it out in case vscode is smarter than me...wich it probably is. 

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>(); //stop forgetting ()
    private int _score = 0; // Gotta start somewhere. 

    public void Start()
    {
        int selection;
        do //this is a fun new loop I have never used before! I shold see if it is available in python. 
        {
            Console.WriteLine("\nMenu Options:"); //need to start new line, was hard to look at. 
            Console.WriteLine("1. Display Player Info");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Create New Goal");
            Console.WriteLine("4. Report");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Quit");

            Console.WriteLine($"What would you like to do?"); //I have never noticed that the $ is required for WriteLine before (with no variables), it can be a Write and not have it. I wonder why. Also don't forget you don't need \n in c# on WriteLine.   
            selection = int.Parse(Console.ReadLine());
            switch (selection)
            {
                case 1:
                    DisplayPlayerInfo();
                    break;
                case 2:
                    ListGoalDetails();
                    break;
                case 3:
                    CreateGoal();
                    break;
                case 4:
                    RecordEvent();
                    break;
                case 5:
                    SaveGoals();
                    break;
                case 6:
                    LoadGoals();
                    break;
            }
        } while (selection != 7); //I know its odd to not have the while loop on the same line Garrett...just get over it. That is how the cool kids do Do loops.
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Your current score is: {_score}");
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}"); //period is there for formating. DO NOT DELETE AGAIN
        }
    }

    public void ListGoalDetails()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals found.");
            return;
        }

        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Great! The types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        int type = int.Parse(Console.ReadLine());

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter description: ");
        string desc = Console.ReadLine();
        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case 1:
                _goals.Add(new SimpleGoal(name, desc, points));
                break;
            case 2:
                _goals.Add(new EternalGoal(name, desc, points));
                break;
            case 3:
                Console.Write("Enter target amount: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
                break;
        }
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0) //GOTTA SET SOME GOALS
        {
            Console.WriteLine($"No goals set.");
            return;
        }

        Console.WriteLine("What goal would you like to report on?"); //return and report lol...I think I am funny when its late. 
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }

        int selection = int.Parse(Console.ReadLine()) - 1;
        Goal goal = _goals[selection];
        goal.RecordEvent();

    if (goal is ChecklistGoal cg && cg.IsComplete())
        {
            _score += cg.Points + cg.Bonus;
        }
    else
        {
            _score += goal.Points;
        }
    }

    public void SaveGoals()
    {
        using (StreamWriter output = new StreamWriter("goals.txt"))
        {
            output.WriteLine(_score);
            foreach (Goal g in _goals)
            {
                output.WriteLine(g.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved!");
    }

    public void LoadGoals()
    {
        if (!File.Exists("goals.txt"))
        {
            Console.WriteLine("No save file found.");
            return;
        }

        _goals.Clear();

        string[] lines = File.ReadAllLines("goals.txt");
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            string type = parts[0];
            switch (type)
            {
                case "SimpleGoal":
                    _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4])));
                    break;
                case "EternalGoal":
                    _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                    break;
                case "ChecklistGoal":
                    _goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]),
                        int.Parse(parts[5]), int.Parse(parts[4]), int.Parse(parts[6])));
                    break;
            }
        }
        Console.WriteLine("Goals loaded!");
    }
}