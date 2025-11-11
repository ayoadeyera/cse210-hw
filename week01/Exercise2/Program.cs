using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("Enter your Score number to get your grade: ");
        string userInput = Console.ReadLine();
        int userScore = int.Parse(userInput);

        string letter = "";

        if (userScore >= 90)
        {
            letter = "A";
        }

        else if (userScore >= 80)    
        {
            letter = "B";
        }

        else if (userScore >= 70)
        {
            letter = "C";
        }

        else if (userScore >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (userScore >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Unfortunately, you did not pass. Better luck next time!");
        }
    }
}