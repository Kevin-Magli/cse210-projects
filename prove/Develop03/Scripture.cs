public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(" ").Select(word => new Word(word)).ToList();
 
        // for (int i = 0; i < textArray.Length; i++)
        // {
        //     _words.Add(new Word(textArray[i]));
        // }
       
        
    }
    public void HideRandomWords(int numberToHide)
    {
        // Count visible words
        int visibleWordCount = _words.Count(word => !word.IsHidden());

        // Adjust the number to hide if there are fewer visible words
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

// split the words in the text and store each as a word object in the list _words
// split and then loop through each word
    // create word object and put it into _words