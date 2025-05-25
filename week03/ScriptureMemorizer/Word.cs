using System;
public class Word
{
    private string _word;
    private bool _hidden;

    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }
    public bool Status()
    {
        return _hidden;
    }
    public void Hide()
    {
        _hidden = true;
    }
    public void Show()
    {
        _hidden = false;
    }
    public string GetDisplay()
    {
        if (_hidden == true)
        {
            return new string('_', _word.Length);
        }
        else
        {
            return _word;
        }
    }
}

