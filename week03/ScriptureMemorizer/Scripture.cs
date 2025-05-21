using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, String text)
    {
        _reference = reference;
        _words = new List<Word>();

        String[] wordsArray = text.Split(" ");
        foreach (String theWord in wordsArray)
        {
            Word word = new Word(theWord);
            _words.Add(word);
        }
    }

    public void HideRandomWords(int numWords)
    {
        Random rand = new Random();

        for (int i = 0; i < numWords; i++)
        {
            _words[rand.Next(0, _words.Count)].Hide();
        }
    }

    public string GetDisplayText()
    {
        string text = "";
        foreach (Word word in _words)
        {
            text += word.GetDisplayText() + " ";
        }
        return $"{_reference.GetDisplayText()} {text}";
    }

    public bool IsCompletelyHidden()
    {
        bool areAnyShowing = false;

        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                areAnyShowing = true;
            }
        }

        return !areAnyShowing;
    }
}