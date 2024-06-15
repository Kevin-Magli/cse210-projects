using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please insert your grade percentage: ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

        string letter = "";
        string sign = "";
        float signGiver = grade % 10;

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
            
        }
        
        if (letter == "F" || grade >= 97)
        {
            sign = "";
        }
        else if (signGiver >= 7)
        {
            sign = "+";
        }
        else if (signGiver < 3)
        {
            sign = "-";
        }

        Console.Write($"You received an {letter}{sign}.");

        if (letter == "A")
        {
            Console.WriteLine(" Congratulations!");
        }
        else if (letter == "B")
        {
            Console.WriteLine(" Not bad :)");
        }
        else if (letter == "C")
        {
            Console.WriteLine(" It's a pass :)");
        }
        else if (letter == "D")
        {
            Console.WriteLine(" Well... better start grinding those study sections.");
        }
        else
        {
            Console.WriteLine("Ah the smell of failure in the air... don't worry, this is a great oportunity to learn.");
            Console.WriteLine("It's easier to deal with failure when you view it like experience. You got some now, next time you'll be even better.");
            Console.WriteLine("Good Luck, you can do this!");
            
        }
        
    }
}