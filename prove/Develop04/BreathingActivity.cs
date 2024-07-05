public class BreathingActivity : Activity {

    public BreathingActivity() {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run() {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime stopTime = startTime.AddSeconds(_duration);

        do {
            // have the user breathe in for 5 seconds
            Console.WriteLine("Breathe in...");
            ShowCountdown(5);
            // have the user breathe out for 5 seconds
            Console.WriteLine("Now breathe out...");
            ShowCountdown(5);

        } while (DateTime.Now < stopTime);

        DisplayEndingMessage();
    }

}