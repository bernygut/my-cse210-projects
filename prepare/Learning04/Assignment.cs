class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary()
    {
        string _summary = string.Concat(_studentName, " - ", _topic);
        return _summary;
    }

    public string GetStudentName()
    {
        return _studentName;
    }
}