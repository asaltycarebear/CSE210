using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        //Changed to float so decimals could be used. BYUI grades are in floats. Need to add message for not putting in a number later. 
        float grade = float.Parse(Console.ReadLine());

        //Note to Self:
        //Start High if using Greater than, Start Low if using Less than in the chain.
        string letter; //Must declare variable before if/elif/else but it does not need to be assigned a value

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        //This section is for stretch
        //lastDigit was SO good to learn
        if (letter != "F")
        {
            float lastDigit = grade % 10;

            if (lastDigit >= 7 && letter != "A")  //The Cake is a lie, no A+ for you!
            {
                letter += "+";
            }
            else if (lastDigit < 3)
            {
                letter += "-";
            }
        }
        //end strech

        Console.WriteLine($"Your grade is: {letter}");

        if (grade >= 70)
        {
            Console.WriteLine("Great jorb, you passed the class!");
        }
        else
        {
            Console.WriteLine("Keep working hard, you got this next time around!");
        }
    }
}