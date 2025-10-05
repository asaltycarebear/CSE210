// not user inputs, has animation, timer, starting and ending message - gets parrameter variable from class. 
public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void StartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} activity."); //Why can't i make this sound NOT like a robot???
        Console.WriteLine(_description);
        Console.Write("How many seconds would you like your session to last? ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Get Ready...");
        ShowSpinner(4);
    }

    public void EndMessage()
    {
        Console.WriteLine("Well done!");
        ShowSpinner(4);
        Console.WriteLine($"You have completed {_duration} seconds of the {_name} activity."); //Again with the robot. woof. 
        ShowSpinner(4);
    }

    protected void ShowSpinner(int seconds)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8; // forces terminal to recognise checkmark

        Console.Write("\n");
        string[] symbols = { "  |  ", "   / ", "   — ", "   \\ ", "  |  ", " /  ", " —  ", " \\  " };
        DateTime end = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < end)
        {
            Console.Write("\r" + symbols[i]); // overwrite same line
            i = (i + 1) % symbols.Length; // cycle through
            Thread.Sleep(500); // wait 1/2 second, number is miliseconds
        }

        Console.Write("\r  ✔  \n");
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }
}
