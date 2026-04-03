using System;

class Program
{
    static void Main(string[] args)
    {
    Console.WriteLine("Hello World! This is the Homework Project.");
    


    // Create a simple Assignment 
    Assignment a1 = new Assignment("Solomon Adeyera", "Multiplication");
    Console.WriteLine(a1.GetSummary());

    // Create a MathAssignment
    MathAssignment a2 = new MathAssignment("Abu Abel", "Fractions", "7.3", "8-19");
    Console.WriteLine(a2.GetSummary());
    Console.WriteLine(a2.GetHomeworkList());
    
    // Create a WritingAssignment
    WritingAssignment a3 = new WritingAssignment("Kwabena Nketia", "African Music History", "The African Music Evolution");
    Console.WriteLine(a3.GetSummary());
    Console.WriteLine(a3.GetWritingInformation());


    }

}
