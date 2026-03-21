using System;
/*
 * PREPARATION/ASSIGNMENT: CSE 210 - Journal Program
 * AUTHOR: Ayodeji Solomon Adeyera
 * * EXCEEDING REQUIREMENTS & CREATIVITY:
 * 1. Extended the 'Entry' class to include 'Mood' and 'Location' fields, allowing 
 * the user to capture more contextual data for each journal entry.
 * 2. Implemented a robust data-storage format using a Pipe Delimiter ('|') 
 * instead of a comma. This ensures that user responses containing commas 
 * do not corrupt the file structure during the Save/Load process.
 * 3. Refined the 'Entry' constructor and 'Load' logic to ensure that historical 
 * dates are preserved when loading from a file, rather than being 
 * overwritten by the current system date.
 * 4. Added defensive coding in the 'Load' method to check if a file exists 
 * before attempting to read it, preventing program crashes.
 */
class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        string option = "";

        while (option != "5")
        {
            Console.WriteLine("\nWelcome to the Journal Program!");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            
            option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    string prompt = promptGenerator.GenerateRandomPrompt();
                    Console.WriteLine($"\nPrompt: {prompt}");
                    Console.Write("> ");
                    string entryText = Console.ReadLine();

                    Console.Write("Mood: ");
                    string mood = Console.ReadLine();

                    Console.Write("Location: ");
                    string location = Console.ReadLine();

                    myJournal.AddEntry(prompt, entryText, mood, location);
                    break;

                case "2":
                    myJournal.DisplayAll();
                    break;

                case "3":
                    Console.Write("Enter filename: ");
                    myJournal.LoadFromFile(Console.ReadLine());
                    break;

                case "4":
                    Console.Write("Enter filename: ");
                    myJournal.SaveToFile(Console.ReadLine());
                    break;

                case "5":
                    Console.WriteLine("Goodbye!");
                    break;
            }
        }
    }
}