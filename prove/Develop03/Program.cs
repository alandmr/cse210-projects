using System;

class Program
{
    static private Scripture _bookScripture;
    static private Scripture _bookScripture2;
    static void Main(string[] args)
    {
        // Constructor one
        string[] text = {"Trust", "in", "the", "Lord", "with", "all", "thine", "heart;",
        "and", "lean", "not", "unto", "thine", "own", "understanding.", "In", "all", "thy", "ways", "acknowledge", "him,", "and", "he", "shall"+
        "direct", "thy", "paths."};        
        _bookScripture = new Scripture("Proverbs","3","5-6",text);   

        // Constructor two
        string[] text2 = {"Trust", "in", "the", "Lord", "with", "all", "thine", "heart;",
        "and", "lean", "not", "unto", "thine", "own", "understanding."};        
        _bookScripture2 = new Scripture("Proverbs","3","5",text2);      
        
        // Play Memorizer
        playMemorizer(_bookScripture);
               
    }

    static private void playMemorizer(Scripture bs)
    {
        string userInput = "";

        Console.Clear();        
        bs.displayScriptureRef();
        bs.displayScriptureVerse(); 
        do
        {            
            Console.Write("Press enter to continue or type 'quit' to finish: ");
            userInput = Console.ReadLine().ToLower();
            if (userInput != "quit")
            {
                setBlankSpace(bs);
                Console.Clear();
                bs.displayScriptureRef();
                bs.displayScriptureVerse();                
            } 
            else
            {
                break;
            }           
        }while(isEnable(bs)); 
    }

    static private void setBlankSpace(Scripture bs)
    {
        Random rd = new Random();
        int varRd = 0;          
        string wordString = "";
        string newWord = "";

        // THIS IS DE BLOCK CODE TO EXCEEDING REQUIREMENTS
        // This block of code allow to select only those word that not have been hide
        do
        {
            varRd = rd.Next(1,bs.get_bookRefrence().get_verseText().Count()+1);                
            if (bs.get_bookRefrence().get_verseText()[varRd-1].get_status())
            {
                wordString = bs.get_bookRefrence().get_verseText()[varRd-1].get_wordString();
                for(int i=0; i<wordString.Length;i++)
                {
                    newWord = newWord + "_";
                }
                bs.get_bookRefrence().get_verseText()[varRd-1].set_wordString(newWord);
                bs.get_bookRefrence().get_verseText()[varRd-1].set_status(false);
                break;
            }
        }while(!bs.get_bookRefrence().get_verseText()[varRd-1].get_status() && isEnable(bs));                
    }

    static private Boolean isEnable(Scripture bs)
    {
        int count = 0;
        for (int i = 0; i<bs.get_bookRefrence().get_verseText().Count(); i++)
        {
            if (!bs.get_bookRefrence().get_verseText()[i].get_status())
            {
                count += 1; 
            }
        }

        if (count < bs.get_bookRefrence().get_verseText().Count())
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}