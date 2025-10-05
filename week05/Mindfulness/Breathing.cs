//no user inputs. Will be on a timer. Gets input from user on how much time will be spent on breathing. 
//Meathod will be BreathingCycle (Changed to Run)
//needs to iterate based on total Cycle time divided by user input <--NO USER INPUT. Needs to round somehow. <--NOPE did it differently
//for creativity, added rounding up to the nearest 10 second interval. 

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing",
               "This activity will help you relax by walking you through slow breathing.")
    { }

    public void Run()
    {
        StartMessage();

        int cycle = 10; //duration of full breathing cycle. 

        _duration = (int)(Math.Ceiling((double)_duration / cycle) * cycle); //Still very confused on why int needs () around it. 

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        Console.WriteLine($"\n(Your duration has been rounded up to {_duration} seconds)\n"); //added to show spesifics. 

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(cycle / 2);
            Console.WriteLine("Breathe out...");
            ShowCountdown(cycle / 2);
        }

        EndMessage();
    }
}
