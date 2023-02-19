class Reference
{
    private string _bookName;
    private string _chapter;
    private string _verseRef;
    private List<Word> _verseText;

    public Reference(string bName, string chapter, string verseRef, string[] text)
    {
        this._bookName = bName;
        this._chapter = chapter;
        this._verseRef = verseRef;
        set_verseText(text);
    }

    public string get_bookName()
    {
        return this._bookName;
    }

    public string get_chapter()
    {
        return this._chapter;
    }

    public string get_verseRef()
    {
        return this._verseRef;
    }

    private void set_verseText(string[] text)
    {
        this._verseText = new List<Word>();
        Word vText;        

        foreach(string t in text)
        {
            vText = new Word();
            vText.set_status(true);
            vText.set_wordString(t);
            this._verseText.Add(vText);
        }

        
    }

    public List<Word> get_verseText()
    {
        return this._verseText;
    }

}