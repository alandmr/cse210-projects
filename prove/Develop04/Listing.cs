using System;

class Listing : Mindfulness
{
    private List<string> _questionsList = new List<string>();    

    public Listing()
    {
        LoadMessages();
    }

        private void LoadMessages()
    {            
        string rline;
        StreamReader sReader = new StreamReader("listing.txt");
        int pivot = 1;

        try
        {
            rline = sReader.ReadLine();
            while (rline != null)
            {                
                                       
                if (pivot == 1)
                {
                    string[] parts = rline.Split(",");
                    SetIntroMessage(parts[0]);                 
                    SetDescriptionMessage(parts[1]);
                    _fMessage.Add(parts[2]);
                    _fMessage.Add(parts[3]);
                }

                if (pivot == 2)
                {
                    string[] parts = rline.Split(",");
                    for (int i = 0; i<5; i++)
                    {
                        _questionsList.Add(parts[i]);
                    }
                }
                
                pivot++;
                rline = sReader.ReadLine();                
            }


        }
        catch(Exception e)
        {
            Console.WriteLine($"Exception: {e}");
        }                                               
    }

    public void StartListingActivity(int time)
    {
        SetFinishingMessage($"{_fMessage[0]} {time} seconds {_fMessage[1]}");
        
        Console.WriteLine("List as many responses you can to the following prompt:");

        Random rdm = new Random();
        int varRdm = 0;
        
        varRdm = rdm.Next(0,4);

        Console.WriteLine($"--- {_questionsList[varRdm]} ---");
        Console.Write("You may begin in:");
        for (int j = 3; j>0; j--)
        {
            Console.Write($"{j}");
            Thread.Sleep(1000);         
            Console.Write("\b \b");
        }

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);
      
        Console.WriteLine("");

        int input = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            input++;
        }

        Console.WriteLine($"You listed {input} items");
        
    }

}