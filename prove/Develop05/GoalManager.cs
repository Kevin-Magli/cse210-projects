public class GoalManager {

    private List<Goal> _goals = new List<Goal>();
    private int _totalPoints = 0;

    public GoalManager(List<Goal> goals, int totalPoints) {
        _goals = goals;
        _totalPoints = totalPoints;
    }
    public GoalManager() { }

    public void Start() {

        var choice = 0;
        do
        {
            DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: >");
            choice = int.Parse(Console.ReadLine()); 
            switch (choice) {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    ListGoalDetails();
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 6:
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

        } while (choice != 6);
        
    }
    public void DisplayPlayerInfo() {
        
        string avatar = GenerateAvatar();
        string title = GenerateTitle();

        Console.WriteLine($"Avatar: {avatar}");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"GP (goal points): {_totalPoints}");
    }
    public bool ListGoalNames() {
        if (_goals.All(goal => goal.IsComplete()))
        {
            Console.WriteLine("There are no goals to complete!");
            return false;
        } else {
            foreach (Goal goal in _goals) {
                if (!goal.IsComplete())
                {
                    Console.WriteLine($"{_goals.IndexOf(goal) + 1}. {goal.GetName()}");
                }
            }
            return true;
        }
    }
    public void ListGoalDetails() {

        foreach (Goal goal in _goals) {
            if (goal.IsComplete())
            {
                Console.Write("[X]" + " ");
            } else {
                Console.Write("[ ]" + " ");
            }
            Console.Write(goal.GetName());
            Console.Write($": ({goal.GetDescription()}) ");
            if (goal is ChecklistGoal) {
                ChecklistGoal cg = (ChecklistGoal)goal;
                Console.Write(cg.GetDetailsString());
            }
            Console.WriteLine();
        }
    }
    public void CreateGoal() {

        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("What type of goal would you like to create? >");
        int goalType = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your goal? >");
        string goalName = Console.ReadLine();

        Console.Write("What is a short description of it? >");
        string goalDescription = Console.ReadLine();

        int goalPoints = 0;

        while (true)
        {
            Console.Write("What is the amount of GP associated with this goal? >");
            goalPoints = int.Parse(Console.ReadLine());
            if(!int.TryParse(goalPoints.ToString(), out goalPoints))
            {
                Console.WriteLine("Invalid value. Please enter a valid number.");
                continue;
            } else {
                break;
            }
        }

        switch (goalType) {
            case 1:
                SimpleGoal simpleGoal = new SimpleGoal(goalName, goalDescription, goalPoints);
                _goals.Add(simpleGoal);
                break;
            case 2:
                EternalGoal eternalGoal = new EternalGoal(goalName, goalDescription, goalPoints);
                _goals.Add(eternalGoal);
                break;
            case 3:
                int goalTarget = 0;
                int goalBonusPoints = 0;
                
                Console.Write("How many times does this goal need to be accomplished for a bonus? >");
                goalTarget = int.Parse(Console.ReadLine());
                
                Console.Write("What is the bonus points for accomplishing it that many times? >");
                goalBonusPoints = int.Parse(Console.ReadLine());
                
                ChecklistGoal checklistGoal = new ChecklistGoal(goalName, goalDescription, goalPoints, goalTarget, goalBonusPoints);
                _goals.Add(checklistGoal);
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }
        
    public void RecordEvent() {
        
        if (!ListGoalNames())
        {
            return;
        }
        
        Console.Write("Which goal did you accomplish? >");
        int choice = int.Parse(Console.ReadLine());

        int pointsEarned = _goals[choice - 1].RecordEvent();
        _totalPoints += pointsEarned;
        Console.WriteLine($"Congratulations! You have earned {pointsEarned} GP!");
    }
    public void SaveGoals() {

        Console.Write("What is the filename for the goal file? >");
        string filename = Console.ReadLine() + ".csv";
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_totalPoints);
            foreach (Goal goal in _goals) {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
    public void LoadGoals() {

        Console.Write("What is the filename to load from? >");
        string loadFilename = Console.ReadLine() + ".csv";
        _goals.Clear();
        using (StreamReader inputFile = new StreamReader(loadFilename))
        {
            string line;
            _totalPoints = int.Parse(inputFile.ReadLine());
            while ((line = inputFile.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                string goalType = parts[0];
                string goalName = parts[1];
                string goalDescription = parts[2];
                int goalPoints = int.Parse(parts[3]);
                Goal goal;
                switch (goalType) {
                    case "SimpleGoal":
                        bool goalIsComplete = bool.Parse(parts[4]);
                        goal = new SimpleGoal(goalName, goalDescription, goalPoints, goalIsComplete);
                        break;
                    case "EternalGoal":
                        goal = new EternalGoal(goalName, goalDescription, goalPoints);
                        break;
                    case "ChecklistGoal":
                        int goalBonus = int.Parse(parts[4]);
                        int goalTarget = int.Parse(parts[5]);
                        int goalAmountCompleted = int.Parse(parts[6]);
                        goalIsComplete = bool.Parse(parts[7]);
                        goal = new ChecklistGoal(goalName, goalDescription, goalPoints, goalBonus, goalTarget, goalAmountCompleted, goalIsComplete);
                        break;
                    default:
                        throw new Exception("Unknown goal type: " + goalType);
                }
                _goals.Add(goal);
            }
        }
    }

    public string GenerateAvatar() {
        if (_totalPoints < 5) { return "🫥";}
        else if (_totalPoints < 10) { return "😐";}
        else if (_totalPoints < 20) { return "🙂";}
        else if (_totalPoints < 30) { return "😃";}
        else if (_totalPoints < 40) { return "😁";}
        else if (_totalPoints < 50) { return "😇";}
        else if (_totalPoints < 60) { return "😛";}
        else if (_totalPoints < 70) { return "🤨";}
        else if (_totalPoints < 80) { return "🧐";}
        else if (_totalPoints < 90) { return "🤓";}
        else if (_totalPoints < 100) { return "😎";}
        else if (_totalPoints < 200) { return "😏";}
        else if (_totalPoints < 300) { return "🤯";}
        else if (_totalPoints < 400) { return "🥶";}
        else if (_totalPoints < 500) { return "🤑";}
        else if (_totalPoints < 600) { return "🤠";}
        else if (_totalPoints < 700) { return "👽";}
        else if (_totalPoints < 800) { return "👻";}
        else if (_totalPoints < 900) { return "💩";}
        else if (_totalPoints < 1000) { return "🎃";}
        else if (_totalPoints < 2000) { return "😸";}
        else if (_totalPoints < 3000) { return "👨‍🦱";}
        else if (_totalPoints < 4000) { return "👲";}
        else if (_totalPoints < 5000) { return "🧙‍♂️";}
        else if (_totalPoints < 6000) { return "👮‍♂️";}
        else if (_totalPoints < 7000) { return "👷‍♂️";}
        else if (_totalPoints < 8000) { return "💂‍♂️";}
        else if (_totalPoints < 9000) { return "🕵️‍♂️";}
        else if (_totalPoints < 10000) { return "🧑‍⚕️";}
        else if (_totalPoints < 11000) { return "👨‍🌾";}
        else if (_totalPoints < 12000) { return "👨‍🍳";}
        else if (_totalPoints < 13000) { return "🧑‍🎤";}
        else if (_totalPoints < 14000) { return "🧑‍💻";}
        else if (_totalPoints < 15000) { return "👨‍🏫";}
        else if (_totalPoints < 16000) { return "👨‍💼";}
        else if (_totalPoints < 17000) { return "👨‍🔧";}
        else if (_totalPoints >= 17000) { return "🤴";}
        else { return "💀";}
    }
    public string GenerateTitle() {
        if (_totalPoints < 5) { return "Rookie";}
        else if (_totalPoints < 10) { return "Beginner";}
        else if (_totalPoints < 20) { return "Happy";}
        else if (_totalPoints < 30) { return "Motivated";}
        else if (_totalPoints < 40) { return "Energetic";}
        else if (_totalPoints < 50) { return "Angelic";}
        else if (_totalPoints < 60) { return "Silly";}
        else if (_totalPoints < 70) { return "Analyst";}
        else if (_totalPoints < 80) { return "Fancy";}
        else if (_totalPoints < 90) { return "Nerd";}
        else if (_totalPoints < 100) { return "Cool";}
        else if (_totalPoints < 200) { return "Smooth";}
        else if (_totalPoints < 300) { return "Mindblowing";}
        else if (_totalPoints < 400) { return "Chill";}
        else if (_totalPoints < 500) { return "Gangsta";}
        else if (_totalPoints < 600) { return "Outsider";}
        else if (_totalPoints < 700) { return "✌︎☹︎✋︎☜︎☠︎";}
        else if (_totalPoints < 800) { return "Spooky";}
        else if (_totalPoints < 900) { return "Smelly";}
        else if (_totalPoints < 1000) { return "Pumpkin of course";}
        else if (_totalPoints < 2000) { return "Cat lover";}
        else if (_totalPoints < 3000) { return "Human";}
        else if (_totalPoints < 4000) { return "Kid";}
        else if (_totalPoints < 5000) { return "Mage";}
        else if (_totalPoints < 6000) { return "Cop";}
        else if (_totalPoints < 7000) { return "Engineer";}
        else if (_totalPoints < 8000) { return "Guard";}
        else if (_totalPoints < 9000) { return "Detective";}
        else if (_totalPoints < 10000) { return "Medic";}
        else if (_totalPoints < 11000) { return "Farmer";}
        else if (_totalPoints < 12000) { return "Linguini";}
        else if (_totalPoints < 13000) { return "Rockstar";}
        else if (_totalPoints < 14000) { return "Super Nerd";}
        else if (_totalPoints < 15000) { return "Professor";}
        else if (_totalPoints < 16000) { return "Boss";}
        else if (_totalPoints >= 17000) { return "K I N G";}
        else { return "???";}
    }

}