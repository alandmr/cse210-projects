using System;

public class Journal
{
    public string _date;
    public DateTime theCurrentTime = DateTime.Now;
    public string _prompt;
    public string _answerPrompt;

    public void writeOption()
    {
        PromptsList pl = new PromptsList();
        
        _prompt = pl.DisplayPrompts();
        Console.Write($"{_prompt}: ");
        _answerPrompt = Console.ReadLine();
        _date = theCurrentTime.ToShortDateString();        
    } 

    public void readOption(Journal j, string d, string p, string a)
    {
        j._date = d;
        j._prompt = p;
        j._answerPrompt = a;
    }
}
