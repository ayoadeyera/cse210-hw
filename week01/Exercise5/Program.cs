using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");


        // Write several simple C# functions

        // 1. Display Welcom Message
        static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to this program!");
        }

        // Call the function to display the welcome message
        DisplayWelcomeMessage();

        // Ask for and return user's name as a string
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }
        // Call the funtion to prompt the user for their name
        string userName = PromptUserName();

        //Ask for and return the user's favorite number as an integer
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        // Call the function to prompt the user for their favorite number
        int number = PromptUserNumber();
        
        // Accept an integer as a parameter and return that number squared
        static int SquareNumber(int number)
        {
            int squared = number * number;
            return squared;
            
        }

        // Call the funtion to square the user's favorite number and display the result
        int squaredNumber = SquareNumber(number);
        Console.WriteLine($"{userName}, your favorite number squared is {squaredNumber}.");

        //
    
    }
}