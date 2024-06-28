using System;

class Program
{
    static void Main(string[] args)
    {
        Reference chosenReference = new Reference("John", 3, 16);
        string chosenScripture = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";

        Scripture scripture = new Scripture(chosenReference, chosenScripture);

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("Press enter to continue or 'q' to quit.");
        string userInput = Console.ReadLine();

        while (userInput != "q")
        {

            scripture.HideRandomWords(3);
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("You have completed the scripture.");
                break;
            }
            Console.WriteLine("Press enter to continue or 'q' to quit.");
            userInput = Console.ReadLine();
        }
    }
}