public class ListingActivity : Activity {

    private int _count = 0;
    private List<string> _prompts = new List<string>() {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void Run() {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime stopTime = startTime.AddSeconds(_duration);

        Console.Clear();
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine("Take 10 seconds to think about this prompt.");
        Console.WriteLine("Then, list as many responses as you can.");
        ShowCountdown(10);
        Console.WriteLine("Start!");
        Thread.Sleep(1000);

        do {
            Console.Write("> ");
            string response = Console.ReadLine();
            GetListFromUser().Add(response);
            _count++;
        

        } while (DateTime.Now < stopTime);
        Console.WriteLine("You listed " + _count + " items. Very good!");
        DisplayEndingMessage();
    }
    public string GetRandomPrompt(){
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
    public List<string> GetListFromUser(){
        List<string> responses = new List<string>();
        return responses;
    }
}