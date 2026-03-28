/*
 * CSE 210 - Scripture Memorizer
 * AUTHOR: Solomon Adeyera
 * * EXCEEDING REQUIREMENTS & CREATIVITY:
 * 1. Implemented a 'ScriptureLibrary' class that loads multiple scriptures 
 * from an external text file (scriptures.txt).
 * 2. The program selects a random scripture from the library each time it 
 * starts, rather than using a single hard-coded verse.
 * 3. Enhanced the UI experience with a final "Good job" message once the 
 * scripture is fully hidden.
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        // Initialize the library and load from the text file
        ScriptureLibrary library = new ScriptureLibrary();
        library.LoadScriptures("scriptures.txt");

        // Ask the library to give us one random scripture to practice
        Scripture scripture = library.GetRandomScripture();

        string input = "";

        // The main game loop
        while (input.ToLower() != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();

            // Show the current state (Reference + Words/Underscores)
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");

            input = Console.ReadLine();

            if (input.ToLower() != "quit")
            {
                scripture.HideRandomWords(3);
            }
        }

        // Final display once complete
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nGood job! You've finished the memorization.");
    }
}