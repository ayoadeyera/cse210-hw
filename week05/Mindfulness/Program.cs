/* EXCEEDING REQUIREMENTS TO SHOW CREATVITY:
   1. Added a 4th Activity: I implemented a 'Grounding Activity' (5-4-3-2-1 technique) 
      This shows the ability to extend the inheritance structure.
   
   2. Time-Slicing Logic: In the Grounding Activity, I added math logic to divide 
      the user's total 'duration' by 5. This ensures that the time is distributed 
      equally across all five sensory prompts (Sight, Touch, Sound, Smell, Taste).
   
   3. Enhanced UX: I Added a custom 'Sign-off' message that only triggers when the 
      user selects 'Quit', providing a more professional and mindful conclusion 
      to the user experience.
*/



using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        string choice = "";
        while (choice != "5")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Start grounding activity"); // Added this option to the menu
            Console.WriteLine(" 5. Quit");
            Console.Write("Select a choice from the menu; ");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
            }
            else if (choice == "2")
            {
                ReflectingActivity activity = new ReflectingActivity(); 
                activity.Run();
            }
            else if (choice == "3")
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();
            }

            else if (choice == "4")
            {
                GroundingActivity activity = new GroundingActivity();
                activity.Run();
            }

        }
        Console.Clear();
        Console.WriteLine("Thank you for using the Mindfulness Program.");
        Console.WriteLine("Remember: Peace comes from within. Have a wonderful, stress-free day!");
        Console.WriteLine();
    }
}