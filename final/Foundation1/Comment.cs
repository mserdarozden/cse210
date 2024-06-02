public class Comment
{
    public string _name;
    public string _text;

    public Comment()
    {
        
    }

    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"Commenter: {_name} comment: {_text}");
    }
}

