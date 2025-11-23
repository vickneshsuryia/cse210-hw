
class SimpleGoal : Goal
{
    //constructors
    public SimpleGoal(string name, string description, int points) : base(name, description, points) { }

    public SimpleGoal(string name, string description, int points, bool isComplete) : base(name, description, points, isComplete) { }
    //methods
    public override int RecordEvent()
    {
        if (!IsComplete())
        {
            SetComplete(true);
            return GetPoints();
        }
        return 0;
    }

    public override string DisplayStatus()
    {
        return IsComplete() ? "[X] " + GetName() : "[ ] " + GetName();
    }

    public override string GetStringRepresentation()
    {
        return "SimpleGoal|" + GetName() + "|" + GetDescription() + "|" + GetPoints() + "|" + IsComplete();
    }
}
