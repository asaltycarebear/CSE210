//needs starting question, and one follow up. 
//needs list of Starting prompts
//needs list of Follow up prompts
//meathod feeding start up prompt message
//meathod for random starting follow up prompt
//Createive requirement ask user for amount of questions to ponder

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What could you learn from this experience?",
        "What did you learn about yourself?"
    };

    public ReflectionActivity() 
        : base("Reflection", 
               "This activity helps you reflect on times of strength and resilience.") { }

    public void Run()
    {
        StartMessage();
        Random rand = new Random();

        Console.WriteLine(_prompts[rand.Next(_prompts.Count)]); // one prompt
        ShowSpinner(16);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            string q = _questions[rand.Next(_questions.Count)]; // many questions
            Console.WriteLine(q);
            ShowSpinner(16);
        }

        EndMessage();
    }
}
