using System;
//I found my old assignement as a guide, I like to have the start message, and wanted to learn input conversions
class Program
{
    static void Main(string[] args)
    {
        bool end = false; //To declare a boolean, like string, int or float you must state you are declaring it. Things break otherwise. Must look up later
        string play = "y"; //needed for while loop to start. 
        Random random = new Random(); //Random is a class type

        while (play == "y")
        {
            int magic_number = random.Next(1, 101); // greater than or equal to 1, and less than 101. Still don't like that. 
            int? guess = null; //? required to allow guess to be null to start. otherwise it would have to be a number. 
            int attempts = 0;

            Console.Write("Would you like to guess my number? (Y/N) "); //REMEMBER INDENTATION DOES NOT ACTUALLY MATTER. Even if this breaks your brain that saying no right away can still run the game and send Have a great day message.
            play = Console.ReadLine().Trim().ToLower();

            while (guess != magic_number)
            {
                if (play == "y" && end == false)
                {
                    attempts++; //attempt counter for stretch

                    Console.Write("What is your guess? ");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out int number))
                    {
                        guess = number;

                        if (guess == magic_number)
                        {
                            Console.WriteLine("You got it!");
                            Console.WriteLine($"It took you {attempts} attempts"); //stretch challenge

                            end = true; //I don't think this was ultimatly nessesary. But I have trouble getting things to work without it. 

                            Console.Write("Would you like to guess my number? (Y/N) "); //stretch challenge
                            play = Console.ReadLine().Trim().ToLower();
                        }
                        else if (guess < magic_number)
                        {
                            Console.WriteLine("Higher");
                        }
                        else if (guess > magic_number)
                        {
                            Console.WriteLine("Lower");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please type a valid number."); //Error control line. I am sure there is a better way to do this, but I was using python code as a guide that I wrote before I knew those methods. 
                    }
                }
                else
                {
                    Console.WriteLine("Have a great day!");
                    break;
                }
            }
        }
    }
}