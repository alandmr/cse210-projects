using System;

class MathAssignment : Assignment
{
    private string _textBookSection;
    private string _problems;
    public MathAssignment(string sName, string topic, string textBookSection, string problems) : base(sName, topic)
    {
        _textBookSection = textBookSection;
        _problems = problems;
    }

    public string getHomeWorkList()
    {
        return $"Section {_textBookSection} Problem {_problems}";
    }

}