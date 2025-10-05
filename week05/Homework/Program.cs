using System;

class Program
{
    // static void Main(string[] args)
    // {
    //     Assignment a1 = new Assignment("Garrett Stockwell", "Multiplication");
    //     Console.WriteLine(a1.GetSummary());
    // }

    //     static void Main(string[] args)
    // {
    //     MathAssignment m1 = new MathAssignment("Garrett Stockwell", "Fractions", "1.0", "10-1");
    //     Console.WriteLine(m1.GetSummary()); // from Assignment (Base)
    //     Console.WriteLine(m1.GetHomeworkList()); // from MathAssignment (Sub)
    // }

    static void Main(string[] args)
    {
        WritingAssignment w1 = new WritingAssignment("Garrett Stockwell", "History of the bugs", "All the bug things");
        Console.WriteLine(w1.GetSummary()); // from Assignment (Base)
        Console.WriteLine(w1.GetWritingInformation()); // from WritingAssignment (Sub)
    }
}
