using System;

class Program
{
    static void Main(string[] args)
    {
        Assigment assigment = new Assigment("Samuel Bennett","Multiplication");
        Console.WriteLine($"{assigment.getSummary()}");
    }
}