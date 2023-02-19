using System;

class Scripture
{
    private Reference _bookRefrence;

    public Scripture(string bName, string chapter, string verseRef, string[] text)
    {        
        this._bookRefrence = new Reference(bName, chapter, verseRef, text);        
    }

    public void displayScriptureRef()
    {
        Console.Write($"{this._bookRefrence.get_bookName()} {this._bookRefrence.get_chapter()}:{this._bookRefrence.get_verseRef()} ");

    }

    public void displayScriptureVerse()
    {
        foreach(Word text in _bookRefrence.get_verseText())
        {
            Console.Write($"{text.get_wordString()} ");
        }
        Console.WriteLine("");
    }

    public Reference get_bookRefrence()
    {
        return this._bookRefrence;
    }
}