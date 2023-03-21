using System;

class Program
{
    private static List<Goals> goalList = new List<Goals>();
    private static int globalPoints = 0;

    static void Main(string[] args)
    {
                
        string option ="";        

        MainMenu();
        do{            
            option = Console.ReadLine();
            if (CorrectOption(option))
            {
                if (option == "1")
                {
                    CreateNewGoal();                    
                }

                if (option == "2")
                {
                    ListGoals();                    
                }

                if (option == "3")
                {
                    SaveGoals();                    
                }

                if (option == "4")
                {
                    LoadGoals();                    
                }

                if (option == "5")
                {
                    RecordEvent();                    
                }

            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Invalid entry, please try again");
                Thread.Sleep(1000);                
            }            
            MainMenu();
        }while(option != "6");
    }

    private static void MainMenu()
    {        
        Console.WriteLine("");
        Console.WriteLine($"You have {globalPoints} points.");
        Console.WriteLine("");
        
        Console.WriteLine("Menu options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.Write("Select a choise from the menu: ");
    }

    private static bool CorrectOption(string op)
    {
        List<string> opList = new List<string>();
        opList.Add("1");
        opList.Add("2");
        opList.Add("3");
        opList.Add("4");
        opList.Add("5");
        opList.Add("6");

        foreach (string n in opList)
        {
            if (n == op)
            {
                return true;                
            }                
        }
        return false;
    }

    private static void CreateNewGoal()
    {
        Console.WriteLine("The types of Goals are: ");
        string option = "";
        SubMenu();
        do{            
            option = Console.ReadLine();
            if (CorrectOption(option))
            {
                if (option == "1")
                {
                    string gName = "";
                    string gDescription = "";
                    int gPoints = 0;
                    Goals simpleGoal;

                    Console.Write("What is the name of your goal? ");
                    gName = Console.ReadLine();

                    Console.Write("What is a short description of it? ");
                    gDescription = Console.ReadLine();

                    Console.Write("What is the amount of points associated with this goal? ");
                    gPoints = int.Parse(Console.ReadLine());

                    simpleGoal = new Goals(gName,gDescription,gPoints,1);
                    simpleGoal.SetState(false);

                    goalList.Add(simpleGoal);
                    break;

                }

                if (option == "2")
                {
                    string gName = "";
                    string gDescription = "";
                    int gPoints = 0;
                    EternalGoal eternalGoal;

                    Console.Write("What is the name of your goal? ");
                    gName = Console.ReadLine();

                    Console.Write("What is a short description of it? ");
                    gDescription = Console.ReadLine();

                    Console.Write("What is the amount of points associated with this goal? ");
                    gPoints = int.Parse(Console.ReadLine());

                    eternalGoal = new EternalGoal(gName,gDescription,gPoints,2);
                    eternalGoal.SetState(false);

                    goalList.Add(eternalGoal);
                    break;

                }

                if (option == "3")
                {
                    string gName = "";
                    string gDescription = "";
                    int gPoints = 0;
                    int timesAccomplished = 0;
                    int bonus = 0;

                    CheckListGoals checkListGoals;

                    Console.Write("What is the name of your goal? ");
                    gName = Console.ReadLine();

                    Console.Write("What is a short description of it? ");
                    gDescription = Console.ReadLine();

                    Console.Write("What is the amount of points associated with this goal? ");
                    gPoints = int.Parse(Console.ReadLine());

                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    timesAccomplished = int.Parse(Console.ReadLine());

                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    bonus = int.Parse(Console.ReadLine());

                    checkListGoals = new CheckListGoals(gName,gDescription,gPoints,3, timesAccomplished, bonus);
                    checkListGoals.SetState(false);

                    goalList.Add(checkListGoals);
                    break;

                }

            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Invalid entry, please try again");
                Thread.Sleep(1000);
                Console.WriteLine();
                SubMenu();
            }            
        }while(!CorrectOption(option));        
    }

    private static void ListGoals()
    {
        int i = 1;
        Console.WriteLine("The goals are:");
        foreach (Goals goals in goalList)
        {
            if (goals.GetState())
            {
                if (goals.GetGoalType() == 3)
                {
                    CheckListGoals chkListGoals = (CheckListGoals)goals;
                    Console.WriteLine($"{i}. [X] {goals.GetGoalName()} ({goals.GetGoalDescription()}) -- Currently completed: {chkListGoals.GetGoaltimesAccomplished()}/{chkListGoals.GetTimesAccomplished()}");    
                }
                else
                {
                    Console.WriteLine($"{i}. [X] {goals.GetGoalName()} ({goals.GetGoalDescription()})");    
                }
                
            }
            else
            {
                if (goals.GetGoalType() == 3)
                {
                    CheckListGoals chkListGoals = (CheckListGoals)goals;
                    Console.WriteLine($"{i}. [ ] {goals.GetGoalName()} ({goals.GetGoalDescription()}) -- Currently completed: {chkListGoals.GetGoaltimesAccomplished()}/{chkListGoals.GetTimesAccomplished()}");    
                }
                else
                {
                    Console.WriteLine($"{i}. [ ] {goals.GetGoalName()} ({goals.GetGoalDescription()})");    
                }
            }
            
            i++;

        }
    }

    private static void SaveGoals()
    {
        string fileName = "";
        Console.Write("Whats is the filename for the goal file? ");
        fileName = Console.ReadLine();

        try
        {
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {                                   
                outputFile.WriteLine($"{globalPoints}");                        
                foreach (Goals goal in goalList)
                {                        
                    if (goal.GetGoalType() == 1)
                    {
                        outputFile.WriteLine($"SimpleGoal:{goal.GetGoalName()},{goal.GetGoalDescription()},{goal.GetGoalPoints()},{goal.GetState()}");                                                                    
                    }

                    if (goal.GetGoalType() == 2)
                    {
                        outputFile.WriteLine($"EternalGoal:{goal.GetGoalName()},{goal.GetGoalDescription()},{goal.GetGoalPoints()}");                                                                    
                    }

                    if (goal.GetGoalType() == 3)
                    {
                        CheckListGoals chkListGoals;
                        chkListGoals = (CheckListGoals) goal;
                        outputFile.WriteLine($"CheckListGoal:{goal.GetGoalName()},{goal.GetGoalDescription()},{goal.GetGoalPoints()},{chkListGoals.GetBonusPoint()},{chkListGoals.GetTimesAccomplished()},{chkListGoals.GetGoaltimesAccomplished()}");                                                                    
                    }                                                                       
                } 
            }
        }catch (Exception e)
        {
            Console.WriteLine($"Error trying to saving file:{e}");
        }
    }

    private static void LoadGoals()
    {
        string fileName = "";
        Console.Write("Whats is the filename for the goal file? ");
        fileName = Console.ReadLine();

        char[] delimiters = {':',','}; 
        string []lines;
        int pivot = 1;

        lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            string[] parts = line.Split(delimiters);
            if (pivot == 1)
            {
                globalPoints = int.Parse(parts[0]);
            }

            if (pivot > 1)
            {
                if (parts[0] == "SimpleGoal")
                {
                    Goals simpleGoal = new Goals(parts[1],parts[2],int.Parse(parts[3]),1);
                    simpleGoal.SetState(bool.Parse(parts[4]));
                    goalList.Add(simpleGoal);
                }

                if (parts[0] == "EternalGoal")
                {
                    EternalGoal EternalGoal = new EternalGoal(parts[1],parts[2],int.Parse(parts[3]),2);
                    goalList.Add(EternalGoal);
                }

                if (parts[0] == "CheckListGoal")
                {
                    CheckListGoals chkListGoal = new CheckListGoals(parts[1],parts[2],int.Parse(parts[3]),3,int.Parse(parts[5]),int.Parse(parts[4]));
                    chkListGoal.SetGoaltimesAccomplished(int.Parse(parts[6]));                    
                    if (int.Parse(parts[5]) == int.Parse(parts[6]))
                    {
                        chkListGoal.SetState(true);
                    }
                    goalList.Add(chkListGoal);
                }
            }
            pivot++;
        } 
    }

    private static void SubMenu()
    {           
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("4. Overcome bad habits");
        Console.Write("which type of goal would you like to create? ");
    }

    private static void RecordEvent()
    {
        int i = 1;
        int option = 0;        

        Console.WriteLine("");
        Console.WriteLine("1. Record goal accomplished? ");
        Console.WriteLine("2. Mark as not done due to bad habits? ");
        Console.Write("Select one: ");
        option = int.Parse(Console.ReadLine());

        Console.WriteLine("");

        if (option == 1)
        {
            Console.WriteLine("The goals are:");
            foreach (Goals goals in goalList)
            {
                Console.WriteLine($"{i}. {goals.GetGoalName()}");
                i++;
            }
            Console.Write("Which goal did you accomplished? ");
            option = int.Parse(Console.ReadLine());
            
            goalList[option-1].GoalCompleted(ref globalPoints);        
            Console.WriteLine($"You now have {globalPoints} points.");
        }

        if (option == 2)
        {
            Console.WriteLine("What goal did you not achieve? ");
            foreach (Goals goals in goalList)
            {
                Console.WriteLine($"{i}. {goals.GetGoalName()}");
                i++;
            }
            Console.Write("Please select one: ");
            option = int.Parse(Console.ReadLine());
            
            goalList[option-1].GoalNotComplete(ref globalPoints);        
            Console.WriteLine($"You now have {globalPoints} points.");

        }

        

        
        

        

    }

}