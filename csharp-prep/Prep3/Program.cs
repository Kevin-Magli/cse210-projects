using System;

class Program
{
    static void Main(string[] args)
    {
        string newGame;
        do
        {    
            Random randomGenerator = new();
            int magicNumber = randomGenerator.Next(1,101);
            int guess;
            int attempt = 1;

            Console.WriteLine(magicNumber);

            do
            {
                Console.WriteLine($"Attempt {attempt}");
                Console.Write("What is the magic number? -> ");
                string userInput = Console.ReadLine();
                guess = int.Parse(userInput);  
                if (!(guess == magicNumber))
                {
                    if (guess > magicNumber)
                    {
                        Console.WriteLine("Lower...");
                    }
                    else if (guess < magicNumber)
                    {
                        Console.WriteLine("Higher...");
                    }

                    Console.WriteLine("Try Again.");
                    attempt++;
                }
                    
            } while (!(guess == magicNumber));
            
            Console.WriteLine("You guess it right!");
            Console.WriteLine($"You found the magic number in {attempt} attempts.");

            Console.Write("Do you want to play it again?[y/n] -> ");
            newGame = Console.ReadLine();
        
        } while (newGame == "y" || newGame == "Y");
    }
}