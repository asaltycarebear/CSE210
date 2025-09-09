using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        //Create List
        int n = 1;
        while (n != 0)
        {
            Console.Write("Add a number to the list (Enter 0 to quit):");

            string un = Console.ReadLine();
            n = int.Parse(un);

            if (n != 0)
            {
                numbers.Add(n);
            }
        }

        //Find Sum
        int sum = 0;
        foreach (int sN in numbers)
        {
            sum += sN;
        }

        //Find Average
        float avg = ((float)sum) / numbers.Count;

        //Find Max
        int max = 0;
        foreach (int aN in numbers)
        {
            if (aN > max)
            {
                max = n;
            }
        }

        //Display information
        Console.WriteLine($"The sum of your list is: {sum}");
        Console.WriteLine($"The average of your list is: {avg}");
        Console.WriteLine($"The largest number in your list is: {max}");
    }
}
