public class Job
{
    //Declare? (but not assign) Variables
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    //needs meathod, create function, could probably use a list, but this was simple. 
    public void Display()
    {
        Console.WriteLine($"{_jobTitle}, {_company}, {_startYear}-{_endYear}");
    }
}