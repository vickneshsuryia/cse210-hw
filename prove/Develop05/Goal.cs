
abstract class Goal
{
    //attributes
    private string _name;
    private string _description;
    private int _points;
    private bool _isComplete;
    //constructors
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = false;
    }
    public Goal(string name, string description, int points, bool isComplete)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = isComplete;
    }

    //methods
    public string GetName() 
    { 
        return _name; 
    }
    public string GetDescription() 
    {
        return _description; 
    }
    public int GetPoints() 
    { 
        return _points; 
    }
    public bool IsComplete() 
    { 
        return _isComplete; 
    }
    protected void SetComplete(bool value) 
    { 
        _isComplete = value; 
    }

    public abstract int RecordEvent();
    public abstract string DisplayStatus();
    public abstract string GetStringRepresentation();
}
