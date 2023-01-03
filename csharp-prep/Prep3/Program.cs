using System;

class Program
{
    static void Main(string[] args)
    {        
        Random randomGenerator = new Random();
        int magic_number = 0;
        int number;
        string getNumber;
        bool isNumeric;
        string answer = "";
        int trackingGuesses;

        answer = "yes";
        while (answer.ToLower() == "yes")
        {
            magic_number = randomGenerator.Next(1,100);
            number = 0;
            getNumber = "";
            isNumeric = false;
            trackingGuesses = 0;

            do
            {
                Console.Write("What is your guess? ");
                getNumber = Console.ReadLine();
                isNumeric = int.TryParse(getNumber, out number);
                if (isNumeric)
                {
                    trackingGuesses++;
                    if (number < magic_number)
                    {
                        Console.WriteLine("Higher");  
                    }
                    else if (number > magic_number)
                    {
                        Console.WriteLine("Lower");
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("You guessed it!");
                        Console.WriteLine($"Tracking guesses: {trackingGuesses}");
                        Console.WriteLine("");
                    }
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Invalid input");
                    Console.WriteLine("");
                }
            }while(magic_number != number);    

            Console.WriteLine("Do you want to play again? ");
            answer = Console.ReadLine();        
        }
    }
}