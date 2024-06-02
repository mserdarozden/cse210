public class Video
{
    public string _title;
    public string _author;
    public float _length;
    public List<Comment> _comments = new List<Comment>();

    public Video()
    {
        
    }
    public Video(string title, string author, float length)
    {
        _title = title;
        _author = author;
        _length = length;

    }

    public void DisplayVideoDetails()
    {
        Console.WriteLine($"Title : {_title} - Author: {_author} - Lenght: {_length} minutes - Number of commentaries: {_comments.Count}.");
    }

    public void DisplayComments()
    {
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
    }



}