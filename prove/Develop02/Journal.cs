// Manages a collection of journal entries

public class Journal
{
    public static List<string> prompts = new List<string>()
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
    
    public static List<JournalEntry> _entries = new List<JournalEntry>();
    
    public static void AddEntry()
    {
        Random random = new Random();
        int index = random.Next(0, prompts.Count);
        string prompt = prompts[index];
        Console.WriteLine(prompt);

        Console.WriteLine("Enter your response: ");
        string response = Console.ReadLine();
        
        string entryDate = DateTime.Now.ToString("MM/dd/yyyy");

        JournalEntry newEntry = new JournalEntry(prompt, response, entryDate);

        _entries.Add(newEntry);
        
        Console.WriteLine("Journal Entry added!");
    }
    public static void DisplayEntries()
    {
        foreach (JournalEntry entry in _entries)
        {
            Console.WriteLine($"Prompt: {entry._prompt}");
            Console.WriteLine($"Response: {entry._response}");
            Console.WriteLine($"Date: {entry._entryDate}");
            Console.WriteLine("---------------------------------");
        }
    }
    public static void SaveToFile()
    {
        string filePath = "journal.csv";

        using (StreamWriter writer = File.CreateText(filePath))
        {
            foreach (JournalEntry entry in _entries)
            {
                writer.WriteLine($"{entry._prompt},{entry._response},{entry._entryDate}");
            }

            Console.WriteLine("Current journal saved to journal.csv");

            writer.Close();
        }
    }
    public static void LoadFromFile(string filePath)
    {
        _entries.Clear();
        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                if (parts.Length == 3)
                {
                    string prompt = parts[0];
                    string response = parts[1];
                    string date = parts[2];
                    JournalEntry entry = new JournalEntry(prompt, response, date);
                    _entries.Add(entry);
                }
            }
        }
        Console.WriteLine("Journal loaded from journal.csv");
    }
    
}