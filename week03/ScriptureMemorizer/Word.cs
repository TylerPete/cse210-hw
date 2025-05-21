public class Word
{
    private string _word;
    private Boolean _isHidden;

    public Word(string word)
    {
        _isHidden = false;
        _word = word;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Unhide()
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
            string blankedWord = "";
            for (int i = 0; i < _word.Length; i++)
            {
                blankedWord += "_";
            }
            return blankedWord;
        }
        else
        {
            return _word;
        }
    }

}