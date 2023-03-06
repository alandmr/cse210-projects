using System;

class Reflection : Mindfulness
{
    
    private List<string> _promptList = new List<string>();
    private List<ReflectingList> _reflectingList = new List<ReflectingList>();

    public Reflection()
    {
        LoadMessages();
    }
    

    private void LoadMessages()
    {            
        string rline;
        StreamReader sReader = new StreamReader("reflection.txt");
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
                    _promptList.Add(parts[0]);
                    _promptList.Add(parts[1]);
                    _promptList.Add(parts[2]);
                    _promptList.Add(parts[3]);
                }

                if (pivot == 3)
                {
                    string[] parts = rline.Split(",");
                    for (int i = 0; i<9; i++)
                    {
                        ReflectingList rl = new ReflectingList();
                        rl.SetQuestion(parts[i]);
                        rl.SetStatus(true);
                        _reflectingList.Add(rl);
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

    public void StartReflectingActivity(int time)
    {
        SetFinishingMessage($"{_fMessage[0]} {time} seconds {_fMessage[1]}");

        Console.WriteLine("");
        Console.WriteLine("Consider de following prompt:");
        Console.WriteLine("");

        Random rdm = new Random();
        int varRdm = 0;
        
        varRdm = rdm.Next(0,3); 
        
        Console.WriteLine($"--- {_promptList[varRdm]} ---");
        Console.WriteLine("");

        Console.Write("When you have something in mind, press enter to continue.");
        Console.ReadKey();

        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Now ponder of each of following questions as they related to this experience.");
        Console.Write("You may begin in:");
        for (int j = 3; j>0; j--)
            {
                Console.Write($"{j}");
                Thread.Sleep(1000);         
                Console.Write("\b \b");
            }
        Console.Clear();
        Console.WriteLine("");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);       
        
        while (DateTime.Now < endTime)
        {           
           varRdm = rdm.Next(0,8);  
           do
           {                
                if (UsedQuestion(varRdm))
                {
                    Console.Write("");
                    Console.Write($"> {_reflectingList[varRdm].GetQuestion()}");
                    _reflectingList[varRdm].SetStatus(false);
                    StartAnimation(10);
                    Console.WriteLine();
                }
                else
                {
                    varRdm = rdm.Next(0,8);  
                }                
           }while(!UsedQuestion(varRdm));           
        }
    }

    private bool UsedQuestion(int pivot){
        if (_reflectingList[pivot].IsStatus())
        {
            return true;
        }
        return false;
    }

}

