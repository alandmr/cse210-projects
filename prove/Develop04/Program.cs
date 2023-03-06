using System;

// Things that Exceeding Requirements

// 1.- I developed a block of code to make sure no random prompts/questions are selected until they have all been used 
// at least once in that session in the Reflecting Activity.

//2.- I added animation on the text in the Breathing Activity.

//3.- I used file text to load the Starting Message, Description Activity, Finishing Message and Prompts


class Program
{
    static void Main(string[] args)
    {
        string option ="";        

        MainOptions();
        do{            
            option = Console.ReadLine();
            if (CorrectOption(option))
            {
                if (option == "1")
                {
                    BreatheOption();                    
                }

                if (option == "2")
                {
                    ReflectingOption();
                } 

                if (option == "3")
                {
                    ListingOption();
                } 
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Invalid entry, please try again");
                Thread.Sleep(1000);
                MainOptions();
            }
            Console.Clear();
            MainOptions();
        }while(option != "4");
        

    }

    private static void MainOptions()
    {
        Console.Clear();
        Console.WriteLine("Menu options:");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");
        Console.Write("Select a choise from the menu: ");
    }

    private static bool CorrectOption(string op)
    {
        List<string> opList = new List<string>();
        opList.Add("1");
        opList.Add("2");
        opList.Add("3");
        opList.Add("4");

        foreach (string n in opList)
        {
            if (n == op)
            {
                return true;                
            }                
        }
        return false;
    }

    private static void BreatheOption()
    {
        int time = 0;

        Console.Clear();
        Breathing breathing = new Breathing();
        Console.WriteLine(breathing.GetIntroMessage());
        Console.WriteLine("");
        Console.WriteLine(breathing.GetDescriptionMessage());
        Console.WriteLine("");
        Console.Write("How long, in seconds, would you like for you session? ");
        time = int.Parse(Console.ReadLine());
                    
        Console.Clear();
        Console.WriteLine("Get ready...");
        breathing.StartAnimation(4);                    
                    
        Console.WriteLine("");
        Console.WriteLine("");
                                        
        breathing.StartBreathingActivity(time);                    
                    
        Console.WriteLine("");

        Console.WriteLine("Well done!!!");
        breathing.StartAnimation(4);

        Console.WriteLine("");

        Console.WriteLine(breathing.GetFinishingMessage());
        breathing.StartAnimation(5);

    }

    private static void ReflectingOption()
    {
        int time = 0;

        Console.Clear();
        Reflection reflection = new Reflection();
        Console.WriteLine(reflection.GetIntroMessage());
        Console.WriteLine("");
        Console.WriteLine(reflection.GetDescriptionMessage());
        Console.WriteLine("");
        Console.Write("How long, in seconds, would you like for you session? ");
        time = int.Parse(Console.ReadLine());
                    
        Console.Clear();
        Console.WriteLine("Get ready...");
        reflection.StartAnimation(4);                    
                    
        Console.WriteLine("");
                                        
        reflection.StartReflectingActivity(time);           
                    
         Console.WriteLine("");

         Console.WriteLine("Well done!!!");
         reflection.StartAnimation(4);

         Console.WriteLine("");

         Console.WriteLine(reflection.GetFinishingMessage());
         reflection.StartAnimation(5);

    }

    private static void ListingOption()
    {
        int time = 0;

        Console.Clear();
        Listing listing = new Listing();
        Console.WriteLine(listing.GetIntroMessage());
        Console.WriteLine("");
        Console.WriteLine(listing.GetDescriptionMessage());
        Console.WriteLine("");
        Console.Write("How long, in seconds, would you like for you session? ");
        time = int.Parse(Console.ReadLine());
                    
        Console.Clear();
        Console.WriteLine("Get ready...");
        listing.StartAnimation(4);                    
                    
        Console.WriteLine("");
                                        
        listing.StartListingActivity(time);           
                    
         Console.WriteLine("");

         Console.WriteLine("Well done!!!");
         listing.StartAnimation(4);

         Console.WriteLine("");

         Console.WriteLine(listing.GetFinishingMessage());
         listing.StartAnimation(5);

    }
} 