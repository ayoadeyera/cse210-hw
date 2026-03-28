using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    // Constructor: Every word starts visible
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            // Creates a string of underscores the same length as the word
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
}