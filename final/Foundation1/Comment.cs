public class Comment
{
    private string _commenter;
    private string _text;

    public Comment(string commenter, string text)
    {
        _commenter = commenter;
        _text = text;
    }

    public string GetCommenterName()
    {
        return _commenter;
    }

    public string GetText()
    {
        return _text;
    }
}

