// a place gets input from a user, needs to be cleared when saved or loaded
using System;


public class Entry
{
    //I think the get and set can be on the same line, but was not sure about how that should look. UPDATE: yea I like it better
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }


    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"entry: {Response}\n");
    }

    public Entry(string date, string prompt, string response)
    {
        Date = date;
        Prompt = prompt;
        Response = response;
    }
    
    public override string ToString()
    {
        return $"{Date} | {Prompt} | {Response}";
    }
}

//All below is failed/too complicated. Learned how to simplify and use abstractions above! so fun. 
// class Entry
// {
//     private string _date;
//     private string _prompt;
//     private string _response;

//     public string Date
//     {
//         get
//         {
//             return _date;
//         }

//         set
//         {
//             if (!string.IsNullOrWhiteSpace(value))
//                 _date = value;
//         }
//     }

// }