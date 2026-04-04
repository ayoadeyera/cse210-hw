using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "who are people that you have helped this week?",
        "When have you felt the HOly Spirit this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certeain area.")
    {
        
    }

    public void Run()
    {
        DisplayStartMessage();

        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($" --- {GetRandomPrompt()} --- ");
        Console.Write("You may begin in: ");
        ShowCountdown(5);
        Console.WriteLine();

        // Capture the tiems from the user 
        List<string> userList = GetListFromUser();
        _count = userList.Count;

        Console.WriteLine($"YOu listed {_count} items!");
        DisplayEndingMessage();


    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public List<string> GetListFromUser()
    {
        List<string> inputs = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        // Keep asking for input until the time is up
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();

            if (!string.IsNullOrEmpty(input))
            {
                inputs.Add(input);
            }
        }
        return inputs;
    }
}
