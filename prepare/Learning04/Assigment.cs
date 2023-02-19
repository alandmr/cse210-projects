using System;

class Assigment
{
    private string _studentName;
    private string _topic;

    public Assigment(string sName, string topic)
    {
        this._studentName = sName;
        this._topic = topic;
    }

    public string getSummary()
    {
        return this._studentName+" - "+this._topic;
    }
}