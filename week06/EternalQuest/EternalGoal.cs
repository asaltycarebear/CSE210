public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int points)
        : base(shortName, description, points) {} //No need for iscomplete here. Never done. But it does need to exist to inherit variables. 
    public override void RecordEvent()
    {
        // _isComplete = true; // Does not complete, no need for this. 
        Console.WriteLine($"Good job! that earned you {_points} points!");
    }

    public override bool IsComplete()
    {
        // return _isComplete; // Does not complete, no need for this. Return false instead.  
        return false;
    }

    // public override string GetDetailsString() // no need for this entire section. this goal never completes. 
    // {
    //     Console.OutputEncoding = System.Text.Encoding.UTF8;
        
    //     string checkbox = _isComplete ? "[✔]" : "[ ]"; 
    //     return $"{checkbox} {base.GetDetailsString()}";
    // }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{_shortName}|{_description}|{_points}"; //{_isComplete} removed, goal never completes. 
    }
}