using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engeneer";
        job1._company = "Microsoft";
        job1._startYear = 2009;
        job1._endYear = 2011;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2015;
        job2._endYear = 2017;

        Resume myResume = new Resume();

        myResume._name = "Aland Munoz";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);  

        myResume.Display();      

        
    }
}