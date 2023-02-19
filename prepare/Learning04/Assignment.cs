using System;

class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment(string sName, string topic)
    {
        _studentName = sName;
        _topic = topic;
    }

    public string get_studentName()
    {
        return _studentName;
    }

    public string get_topic()
    {
        return _topic;
    }

    public string getSummary()
    {
        return _studentName+" - "+_topic;
    }
}