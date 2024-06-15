using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int square = SquareNumber(userNumber);
        DisplayResult(userName, square);

    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("Tell me your name: ");
        string userInput = Console.ReadLine();
        return userInput;
    }
    static int PromptUserNumber()
    {   
        int favNumber;
        Console.Write("Tell me your favorite number: ");
        string userInput = Console.ReadLine();
        favNumber = int.Parse(userInput);
        return favNumber;
    }
    static int SquareNumber(int number)
    {
        int squared = number * number;
        return squared;
    }
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}.");
    }
}