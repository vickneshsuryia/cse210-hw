
class EternalGoal : Goal
{
    //constructor
    public EternalGoal(string name, string description, int points) : base(name, description, points) { }
    //methods
    public override int RecordEvent()
    {
        return GetPoints();
    }

    public override string DisplayStatus()
    {
        return "[∞] " + GetName();
    }

    public override string GetStringRepresentation()
    {
        return "EternalGoal|" + GetName() + "|" + GetDescription() + "|" + GetPoints();
    }
}
