using System;
public class GroundingActivity : Activity
{
    public GroundingActivity() : base("Grounding Activity", "This activity will help you stay in the present moment by focusing on your five senses. It is excellent for reducing sudden stress.")
    {
        
    }
    public void Run()
    {
        DisplayStartMessage();

        // We will divide the chosen duration by 5 steps
        int stepDuration = _duration / 5;
        
        Console.WriteLine("Focus on your surroundings...");
        ShowSpinner(3);
        
        // Step 5: Sight
        Console.WriteLine("\nLook around you. Notice 5 things you can SEE.");
        
        ShowSpinner(stepDuration);
        
        // Step 4: Touch
        Console.WriteLine("Notice 4 things you can FEEL (e.g., your feet on the floor, the fabric of your clothes)");
        ShowSpinner(stepDuration);
        
        
        // Step 3: Sound
        Console.WriteLine("Listen closely. Notice 3 things you can HEAR.");
        ShowSpinner(stepDuration);

        // Step 2: Smell
        Console.WriteLine("Breathe in. Notice 2 things you can SMELL.");
        ShowSpinner(stepDuration);

        // Step 1: Taste
        Console.WriteLine("Finally, notice 1 thing you can TASTE (or your favorite thing to taste).");
        ShowSpinner(stepDuration);

        DisplayEndingMessage();
    }
}