using System;

class Reference
{
    private string _book;
    private int _verse;
    private int _lastVerse;
    private int _chapter;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _lastVerse = -1; //going to make this a range, so I can use an if statment to return the printed reference
    }

    public Reference(string book, int chapter, int verse, int lastVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _lastVerse = lastVerse;
    }

    public string GetDisplayText()
    {
        if (_lastVerse == -1)
            return $"{_book} {_chapter}:{_verse}";

        else
            return $"{_book} {_chapter}:{_verse}-{_lastVerse}";
    }
}