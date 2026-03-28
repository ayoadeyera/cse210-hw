using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        // Split the text into an array of strings based on spaces
        string[] splitWords = text.Split(' ');

        foreach (string wordText in splitWords)
        {
            // Create a Word object for each piece of text and add to the list
            _words.Add(new Word(wordText));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int hiddenSoFar = 0;

        // Keep trying until we hit the target or everything is hidden
        while (hiddenSoFar < numberToHide && !IsCompletelyHidden())
        {
            int randomIndex = random.Next(_words.Count);

            if (!_words[randomIndex].IsHidden())
            {
                _words[randomIndex].Hide();
                hiddenSoFar++;
            }
        }
    }

    public string GetDisplayText()
    {
        string textToDisplay = "";
        foreach (Word word in _words)
        {
            textToDisplay += word.GetDisplayText() + " ";
        }
        
        return $"{_reference.GetDisplayText()} {textToDisplay.Trim()}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}