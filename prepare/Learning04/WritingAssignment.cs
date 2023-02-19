using System;

class WritingAssignment : Assignment
{
    private string _title;
    public WritingAssignment(string sName, string topic, string title) : base(sName, topic)
    {
        _title = title;
    }

    public string getWritingInformation()
    {
        
        string studentName = get_studentName();

        return $"{_title} by {studentName}";
    }
}