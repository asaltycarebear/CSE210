using System;

using System.Transactions;

public class Video
{
    public string _title;
    public string _author;
    public int _lengthInSeconds;
    private List<Comment> _comments;

    public Video(string title, string author, int lengthInSeconds)
    {
        this._title = title;
        this._author = author;
        this._lengthInSeconds = lengthInSeconds;
        _comments = new List<Comment>();
    }

    public string GetTitle()
    {
        return _title;
    }

    public void SetTitle(string title)
    {
        this._title = title;
    }

    public string GetAuthor()
    {
        return _author;
    }
    public void SetAuthor(string author)
    {
        this._author = author;
    }

    public int GetLengthInSeconds()
    {
        return _lengthInSeconds;
    }
    public void SetLengthInSeconds(int lengthInSeconds)
    {
        this._lengthInSeconds = lengthInSeconds;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }
}