using System.Reflection;
using System.Transactions;

public class Video
{
    //attributes
    private string _title;
    private string _author;
    private string _length;
    private List<Comment> _comments = new List<Comment>();
    //constructor
    public Video(string title, string author, string length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    //methods
    public void Display()
    {
        Console.WriteLine($"{_title} by {_author}\nLength: {_length}\nComments({CommentCount()}):");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"{comment.getName()} said {comment.getText()}");
        }
    }
    public int CommentCount()
    {
        return _comments.Count;
    }
    public void AppendComment(Comment comment)
    {
        _comments.Add(comment);
    }
}