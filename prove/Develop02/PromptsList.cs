using System;

public class PromptsList
{
    int _rdPrompts = 0;

    public string DisplayPrompts()
    {
        Random rd = new Random();
        string promptString = "";
        _rdPrompts = rd.Next(1,5);

        if (_rdPrompts == 1)
        {
            promptString = "How was your day at work?";
        }
        else if (_rdPrompts == 2)
        {
            promptString = "Who were you able to serve today?";
        }
        else if (_rdPrompts == 3)
        {
            promptString = "What was the best part of my day?";
        }
        else if (_rdPrompts == 4)
        {
            promptString = "What things can you improve for tomorrow?";
        }
        else if (_rdPrompts == 5)
        {
            promptString = "How did I see the hand of the Lord in my life today?";
        }

        return promptString;
    }
}