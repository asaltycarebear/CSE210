using System;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ') //finally something I understand from spreadsheets!
                    .Select(word => new Word(word))
                    .ToList();
    }
    public void HideRandomWords(int numberToHide)
    {
        Random r = new Random();
        for (int i = 0; i < numberToHide; i++)
        {
            int index = r.Next(_words.Count);
            _words[index].Hide();
        }
    }

    public string GetDisplayText() //same name as reference WICH IS FINE stop freaking out garrett.
    {
        string scriptureText = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        return $"{_reference.GetDisplayText()} - {scriptureText}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}