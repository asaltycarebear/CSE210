using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Running run = new Running(new DateTime(2025, 10, 12), 30, 3.1);
        Cycling cycle = new Cycling(new DateTime(2025, 10, 13), 55, 15.0);
        Swimming swim = new Swimming(new DateTime(2025, 10, 14), 60, 38);

        List<Activity> activities = new List<Activity> { run, cycle, swim };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}