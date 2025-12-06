public class Comment
{
    //attributes
    private string _name;
    private string _text;
    //constructor
    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }
    //methods
    public string getName()
    {
        return _name;
    }
    public string getText()
    {
        return _text;
    }
}