using System;

class ReflectingList
{
    private string _question;
    private bool _status;

    public string GetQuestion()
    {
        return this._question;
    }

    public void SetQuestion(string _question)
    {
        this._question = _question;
    }

    public bool IsStatus()
    {
        return this._status;
    }

    public void SetStatus(bool status)
    {
        this._status = status;
    }


}