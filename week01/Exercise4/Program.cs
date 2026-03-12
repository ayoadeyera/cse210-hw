using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        // Print a message to the user 

        Console.WriteLine("Enter a list of numbers, type o when you are done.:");

        // Declare and initialize a list o f integers
        List<int> numbers = new List<int>();
        // let user continue to add numbers until the user types o

        while (true)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            if (number == 0)
            {
                break;
            }
            numbers.Add(number);

        }

        // Calculate the sum of the numbers in the list
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
            Console.WriteLine($"The sum is: {sum}");
        }

        // Calculate the average of the numbers in the list
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        
        
        // find the largest number in the list
        int largest = numbers[0];
        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;

            }
        }
        Console.WriteLine($"The largest number is: {largest}");
        
        }

        
    }
