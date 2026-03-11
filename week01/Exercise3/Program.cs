using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        
        // Using random number
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        
        int userGuess = -1;
        
        Console.WriteLine("Welcome to my Magic NumberGuessing Game!");
        Console.WriteLine("The Magic Number is between 1 and 100.");
        Console.WriteLine("Try to guess the magic number, just in few tries!");
        
        while (userGuess != magicNumber)
        {
            Console.Write("What is your guess?: ");
            userGuess = int.Parse(Console.ReadLine());

            if (magicNumber > userGuess)
            {
                Console.WriteLine("Go Higher!");
            }
            else if (magicNumber < userGuess)
            {
                Console.WriteLine("Go Lower!");
            }
            else
            {
                Console.WriteLine("Congratulation! You guessed it!");
            }
        }
    }
}