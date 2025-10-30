class WritingAssignment : Assignment
{
    //attributes
    private string _title;
    //methods
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }
    public string GetWritingInformation()
    {
        return $"{_title} by {_studentName}";
    }

}