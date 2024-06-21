using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMenu();
    }
    static void DisplayMenu()
    {
        while (true) 
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Write");
            Console.WriteLine(" 2. Display");
            Console.WriteLine(" 3. Save");
            Console.WriteLine(" 4. Load");
            Console.WriteLine(" 5. Quit");
            Console.Write(" > ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Journal.AddEntry();
                    break;
                case "2":
                    Journal.DisplayEntries();
                    break;
                case "3":
                    Journal.SaveToFile();
                    break;
                case "4":
                    string filePath = "journal.csv";
                    Journal.LoadFromFile(filePath);
                    break;
                case "5":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }
}