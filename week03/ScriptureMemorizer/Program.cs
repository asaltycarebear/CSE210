using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("2 Peter", 1, 2, 8);
        string text = "Grace and peace be multiplied unto you through the knowledge of God, and of Jesus our Lord,\nAccording as his divine power hath given unto us all things that pertain unto life and godliness, through the knowledge of him that hath called us to glory and virtue:\nWhereby are given unto us exceeding great and precious promises: that by these ye might be partakers of the divine nature, having escaped the corruption that is in the world through lust.\nAnd beside this, giving all diligence, add to your faith virtue; and to virtue knowledge;\nAnd to knowledge temperance; and to temperance patience; and to patience godliness;\nAnd to godliness brotherly kindness; and to brotherly kindness charity.\nFor if these things be in you, and abound, they make you that ye shall neither be barren nor unfruitful in the knowledge of our Lord Jesus Christ.\n";
        Scripture scripture = new Scripture(reference, text);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
                    
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            Random rand = new Random();
            int numberToHide = rand.Next(4, 11); // 4–10 words hidden each time, this is the stretch goal
            scripture.HideRandomWords(numberToHide);

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll words are hidden. Program will end.");
                break;
            }
        }
    }
}