public class Word {
    private string _text;
    private bool _isHidden;

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
        if (_isHidden) // if word is hidden, replace word with underscore
        {
            return new string('_', _text.Length);
        }
        else // if not, return the word
        {
            return _text;
        }
    }
}