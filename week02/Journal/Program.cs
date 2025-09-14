// Author: Garrett Stockwell
// Program: Journal
// Description: A program for keeping track of journal entries. Will keep track of multiple entries,
// save entries to a CSV (exceeded requirement), and can load that file to display entries. 
// The file will also be saved to the local Documents folder, not the current folder.  
// There was no guidence on where to store, I can fix that if needed.

using System;

class Program
{
    static void Main(string[] args)
    {
        string name = "Garrett"; //Should add a way to change the name later
        bool quit = false;
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        while (quit != true)
        {
            //This is where the menu goes
            Console.WriteLine($"Hello {name}! How would you like to Journal today?.\n1. Write\n2. Display\n3. Save\n4. Load\n5. Quit\n");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                string response = Console.ReadLine();
                string date = DateTime.Now.ToShortDateString();
                journal.AddEntry(new Entry(date, prompt, response));
            }

            else if (choice == "2")
            {
                journal.DisplayEntries();
            }
            
            else if (choice == "3")
            {
                Console.Write("\nEnter filename (.csv): ");
                string saveFile = Console.ReadLine();
                journal.SaveToCsv(saveFile);
                Console.WriteLine("\nJournal saved.");
            }

            else if (choice == "4")
            {
                Console.Write("\nEnter filename (.csv): ");
                string loadFile = Console.ReadLine();
                journal.LoadFromCsv(loadFile);
                Console.WriteLine("\nJournal loaded.");
            }

            else if (choice == "5")
            {
                quit = true;
            }

            //added error message for not selecting an valid option
            else
            {
                Console.WriteLine($"That is not a choice {name}, please select options 1-5");
            }
        }
    }
}