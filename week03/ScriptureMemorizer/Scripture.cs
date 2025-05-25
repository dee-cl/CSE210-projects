using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class Scripture
{
    private Reference _reference = new Reference("John", 3, 16);
    private string _text = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
    private List<Word> _words;
    
    public Scripture()
    {
        _words = new List<Word>();
        string[] wordList = _text.Split(' ');
        foreach (string word in wordList)
        {
            _words.Add(new Word(word));
        }
    }
    public string displayList()
    {

        string display = "";
        foreach (Word word in _words)
        {
            display += word.GetDisplay() + " ";
        }
        display = display.Trim();
        Console.WriteLine($"{_reference.GetReference()} {display}");
        return display;
    }
    public void HideWords()
    {
        Random random = new Random();
        int numofwords = random.Next(1, 5);
        string[] wordlist = _text.Split(' ');
        int wordcount = 0;
        while (numofwords > 0)
        {
            int index = random.Next(wordlist.Length);
            if (_words[index].Status() == false)
            {
                _words[index].Hide();
                numofwords--;
                wordcount++;
            }
            if (wordcount == wordlist.Length)
            break;
        }
    }
    public bool AllWordsHidden()
{
    foreach (Word word in _words)
    {
        if (!word.Status())
            return false;
    }
    return true;
}
}