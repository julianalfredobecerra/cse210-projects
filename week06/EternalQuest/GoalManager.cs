using System;
using System.IO; 
class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }
    
    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStringRepresentation()}");
        }
    }
    
    public void ListGoalDetails()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Choose goal type: 1) Simple 2) Eternal 3) Checklist");
        int choice = int.Parse(Console.ReadLine());
        
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        
        Console.Write("Enter description: ");
        string desc = Console.ReadLine();
        
        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            _goals.Add(new SimpleGoal(name, desc, points));
        }
        else if (choice == 2)
        {
            _goals.Add(new EternalGoal(name, desc, points));
        }
        else if (choice == 3)
        {
            Console.Write("Enter target count: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Enter bonus: ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
        }
    }

    public void RecordEvent()
    {
        Console.Write("Enter goal number to record an event: ");
        int goalNum = int.Parse(Console.ReadLine()) - 1;
        if (goalNum >= 0 && goalNum < _goals.Count)
        {
            _goals[goalNum].RecordEvent();
            _score += _goals[goalNum].IsComplete() ? _goals[goalNum].Points : 0;
            Console.WriteLine("Event recorded!");
        }
    }

    public void SaveGoals()
    {
        string fileName = "goals.txt";
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (var goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        if (File.Exists("goals.txt"))
        {
            string[] lines = File.ReadAllLines("goals.txt");
            _score = int.Parse(lines[0]);
        }
    }
}