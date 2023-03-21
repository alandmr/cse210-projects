using System;

class Goals
{
    private string _goalName;
    private string _goalDescription;
    private int _goalPoints;
    private bool _goalState;
    private int _goalType;

    public Goals(string gName, string gDescription, int gPoints, int gType)
    {
        this._goalName = gName;
        this._goalDescription = gDescription;
        this._goalPoints = gPoints;
        this._goalType = gType;
    }

    public string GetGoalName()
    {
        return this._goalName;
    }


    public string GetGoalDescription()
    {
        return this._goalDescription;
    }


    public int GetGoalPoints()
    {
        return this._goalPoints;
    }

    public void SetState(bool state)
    {
        this._goalState = state;
                
    }

    public bool GetState()
    {
        return this._goalState;
    }

    public int GetGoalType()
    {
        return this._goalType;
    }

    public virtual void GoalCompleted(ref int globalPoint)
    {

        this._goalState = true;
        Console.WriteLine($"Congratulations! You have earned {this._goalPoints} points!");
        globalPoint += this._goalPoints;
        
    }

    public virtual void GoalNotComplete(ref int globalPoint)
    {
        Console.WriteLine($"Sorry you lost {this._goalPoints} points!");
        globalPoint -= this._goalPoints; 
        this._goalState = false;
    }


}