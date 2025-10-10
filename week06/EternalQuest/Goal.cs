// meathods: Title, Description, points

//using System.Security.Cryptography.X509Certificates; //what is with these auto fills???? notating out for now. 

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public int Points // This is so I can keep _points protected. 
    {
        get { return _points; }
    }


    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        return $"{_shortName} {_description}";
    }

    public abstract string GetStringRepresentation();
}