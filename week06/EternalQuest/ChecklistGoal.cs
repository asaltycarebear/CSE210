public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public int Bonus //this is so I can keep _bonus protected here. 
    {
        get { return _bonus; }
    }

    public ChecklistGoal(string shortName, string description, int points, int target, int bonus, int amountCompleted = 0) // declare amount completed in paramaters, so it can be fed later. way to go problem counter!
        : base(shortName, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

        public override void RecordEvent()
    {
        _amountCompleted++;
        Console.WriteLine($"Good job! that earned you {_points} points!");

        if (IsComplete()) // needs if statement for 100% 
        {
            Console.WriteLine($"*** WOOOOO! {_shortName.ToUpper()} is completed and earned you a bonus of {_bonus} points! WEEEEE ***");
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        
        string checkbox = IsComplete() ? "[✔]" : "[ ]"; //needs to reference meathod in this class, because there is partial completions. Maybe change symbol if partial completion.  
        return $"{checkbox} {base.GetDetailsString()} - Completed {_amountCompleted}/{_target} times"; //WHYYYYY I don't get this still. This feels like it should be an infinit loop. I wish c# could debug so I could see how this was happening. 
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_bonus}|{_target}|{_amountCompleted}";
    }
}