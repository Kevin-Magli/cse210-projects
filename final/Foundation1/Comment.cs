public class Comment
{
    private string _text;
    private string _author;

    public Comment(string text, string author)
    {
        _text = text;
        _author = author;
    }
    
    public string GetText()
    {
        return _text;
    }
    public string GetAuthor()
    {
        return _author;
    }
}   