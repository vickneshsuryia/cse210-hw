
class ChecklistGoal : Goal
{
    //attributes
    private int _targetCount;
    private int _currentCount;
    private int _bonus;
    //constructors
    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus) : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonus = bonus;
        _currentCount = 0;
    }
    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus, int currentCount) : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonus = bonus;
        _currentCount = currentCount;
    }
    //methods
    public override int RecordEvent()
    {
        _currentCount++;
        if (_currentCount >= _targetCount)
        {
            SetComplete(true);
            return GetPoints() + _bonus;
        }
        return GetPoints();
    }

    public override string DisplayStatus()
    {
        return IsComplete() ? "[X] " + GetName() + " Completed " + _currentCount + "/" + _targetCount
                            : "[ ] " + GetName() + " Completed " + _currentCount + "/" + _targetCount;
    }

    public override string GetStringRepresentation()
    {
        return "ChecklistGoal|" + GetName() + "|" + GetDescription() + "|" + GetPoints() + "|" + _targetCount + "|" + _bonus + "|" + _currentCount;
    }
}