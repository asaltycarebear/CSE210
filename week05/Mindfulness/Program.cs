//Need menu to start program, will include options for Breathing Reflection, Listing, and Quitting.
using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        string[] symbols = { "  |  ", "   / ", "   — ", "   \\ ", "  |  ", " /  ", " —  ", " \\  " };

        int index = 0;

        while (true) // infinite loop
        {
            Console.Write("\r" + symbols[index]); // overwrite same line
            index = (index + 1) % symbols.Length; // cycle through
            Thread.Sleep(1000); // wait 1 second, number is miliseconds
        }
    }
}