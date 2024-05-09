public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] splitText = text.Split(" ");
        foreach (string word in splitText)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
        int wordsHidden = 0;

        // check if they're isHidden already
        while (wordsHidden < numberToHide)
        {
            int index = rand.Next(_words.Count);
            Word wordToHide = _words[index];

            if (!wordToHide.IsHidden())
            {
                // if they are not isHidden, hide them
                wordToHide.Hide();
                wordsHidden++;
            }
        }
    }

    public string GetDisplayText()
    {
        string displayText = $"{_reference.GetDisplayText()} ";
        
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText;
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