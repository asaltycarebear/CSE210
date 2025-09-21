using System;

class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false; //you should start with everything beeing seen
    }

    public void Hide()
    {
        _isHidden = true; //setter
    }

    public bool IsHidden()
    {
        return _isHidden; //getter
    }

    public string GetDisplayText() //same name as reference WICH IS FINE stop freaking out garrett.
    {
        return _isHidden ? new string('_', _text.Length) : _text; //the ? acts like if & else. _isHidden is a Bool, so if true, then it will use the new string, if not, then will keep current _text string
    }
}