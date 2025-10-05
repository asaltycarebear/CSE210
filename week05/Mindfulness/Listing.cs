//one meathod to get random prompt from list, and list as many as  you can think of in set time.
//could add the round up and cycle here, but ran out of time. In the future I probably could add that to the base class, but not every cycle has the same activity lenght. 

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people you have helped this week?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
        : base("Listing",
               "This activity helps you list as many good things as possible in a given area.")
    { }

    public void Run()
    {
        StartMessage();
        Random rand = new Random();
        Console.WriteLine(_prompts[rand.Next(_prompts.Count)]);
        ShowCountdown(5);

        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            items.Add(Console.ReadLine());
        }

        Console.WriteLine($"You listed {items.Count} items!");
        EndMessage();
    }
}
