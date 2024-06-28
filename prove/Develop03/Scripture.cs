public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(" ").Select(word => new Word(word)).ToList();
    }
    public void HideRandomWords(int numberToHide)
    {
        
        int visibleWordCount = _words.Count(word => !word.IsHidden());

        if (visibleWordCount < numberToHide)
        {
            numberToHide = visibleWordCount;
        }

        int count = 0;
        Random random = new Random();

        while (count < numberToHide)
        {
            int index = random.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                count++;
            }
        }
    } 
    public string GetDisplayText()
    {
        return _reference.GetDisplayText() + " " + string.Join(" ", _words.Select(word => word.GetDisplayText()));
    }
    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}