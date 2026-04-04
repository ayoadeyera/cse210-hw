using System;

public class BreathingActivity : Activity
{
    // The constructor calls the "base" to set the name and description automatically
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mmind and focus on your breathing.")
    {
        
    }
    public void Run()
    {
        // Dispay the standard starting messages from the parent class
        DisplayStartMessage();

        // Prepare the timer
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        // Loop until the time is up
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(4); // Call the countdown from the parent

            Console.WriteLine();
            Console.Write("Now breathe out...");
            ShowCountdown(6);
            Console.WriteLine();
        }

        // Display the standard ending messages from the parent class
        DisplayEndingMessage();
    }
}