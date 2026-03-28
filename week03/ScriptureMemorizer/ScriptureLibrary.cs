using System;
using System.Collections.Generic;
using System.IO;

public class ScriptureLibrary
{
    private List<Scripture> _scriptures = new List<Scripture>();

    public void LoadScriptures(string filename)
    {
        // Eensure the file exists before trying to read it
        if (!File.Exists(filename))
        {
            Console.WriteLine($"Error: {filename} not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            // We use the Pipe '|' as the divider
            string[] parts = line.Split('|');

            // We expect exactly 5 parts: Book, Chapter, StartVerse, EndVerse, Text
            if (parts.Length == 5)
            {
                string book = parts[0];
                int chapter = int.Parse(parts[1]);
                int startVerse = int.Parse(parts[2]);
                int endVerse = int.Parse(parts[3]);
                string text = parts[4];

                // Create the Reference and then the Scripture object
                Reference reference = new Reference(book, chapter, startVerse, endVerse);
                Scripture newScripture = new Scripture(reference, text);

                _scriptures.Add(newScripture);
            }
        }
    }

    public Scripture GetRandomScripture()
    {
        if (_scriptures.Count == 0)
        {
            return null;
        }

        Random random = new Random();
        int index = random.Next(_scriptures.Count);
        return _scriptures[index];
    }
}