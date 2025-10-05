public class MathAssignment : Assignment //this makes it so all the methods from  Assignment(Base Class) can be used in the MathAssignment (Sub Class)
{
    private string _textbookSection;
    private string _problems;

    //DO NOT CREATE variables that have already been declared in Base Class. This will break things. 
    public MathAssignment(string studentName, string topic, string textbookSection, string problems) //constructor of all parameters
        : base(studentName, topic) //base calles the base class (Assignemnt) to get these variables. Will be used in Main Program.
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section: {_textbookSection} \nProblems: {_problems}";
    }
}