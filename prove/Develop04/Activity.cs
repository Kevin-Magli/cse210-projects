public class Activity {
    
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity() {
        // initialize name, description and duration
        _name = "";
        _description = "";
        _duration = 0;
    }

    public void DisplayStartingMessage() {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}!");
        Console.WriteLine(_description);
        Console.Write("Chose the duration of the activity in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        
    }

    public void DisplayEndingMessage() {
        Console.WriteLine("Well done!!");
        Console.WriteLine($"You have completed the {_name} for {_duration} seconds.");
        ShowSpinner(5);
        Console.Clear();
    }

    public void ShowSpinner(int seconds) {
    var symbols = new []{".  ", ".. ", "..."};
    var spinner = new Task(() =>
    {
        for (int i = 0; i < seconds; i++) {
            var symbol = symbols[i % 3];
            Console.Write("\r{0} ", symbol);
            Thread.Sleep(700);
        }
    });
    spinner.Start();
    spinner.Wait();
    Console.WriteLine();
}

    public void ShowCountdown(int seconds) {
        for (int i = seconds; i > 0; i--) {
            Console.Write("\r{0} ", i);
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

}