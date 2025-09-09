using System;

class Program
{
    static void Main(string[] args) //Just like Python, this should always be at the top, and the rest of the functions will get called as we go.
    {
        DisplayWelcome();

        string uName = PromptUserName();
        int uN = PromptUserNumber();

        int squareN = SquareNumber(uN);

        DisplayResult(uName, squareN);
    }

    //Welcome Message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    //Get the name
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    //Get favorite number
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int n = int.Parse(Console.ReadLine());
        return n;
    }

    //Square that number for some reason
    static int SquareNumber(int n)
    {
        return n * n;
    }

    //The final message
    static void DisplayResult(string name, int squareN)
    {
        Console.WriteLine($"{name}, the square of your number is {squareN}.");
    }
}