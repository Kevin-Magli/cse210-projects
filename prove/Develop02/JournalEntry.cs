// Responsible for storing individual journal entries

public class JournalEntry
{
    public string _prompt;
    public string _response;
    public string _entryDate;

    public JournalEntry(string prompt, string response, string entryDate)
    {
        _prompt = prompt;
        _response = response;
        _entryDate = entryDate;
    }
}