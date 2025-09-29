public class Comment
{
    private string _name;
    private string _text;
    public Comment(string name, string text)
    {
        this._name = name;
        this._text = text;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        this._name = name;
    }

    public string GetText()
    {
        return _text;
    }

    public void SetText(string text)
    {
        this._text = text;
    }
}