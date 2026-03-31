public class Comment
{
    private string _name;
    private string _text;

    public Comment()
    {

    }

    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetText()
    {
        return _text;
    }

    public string Display()
    {
        return $"({_name}: {_text})";
    }
}


