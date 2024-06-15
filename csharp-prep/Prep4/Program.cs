using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers;
        numbers = new List<int>();



        int number;

        do
        {

            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();
            number = int.Parse(userInput);
            if (!(number == 0))
                numbers.Add(number);
        } while (!(number == 0));


        int sum = numbers.Sum();
        int largest = numbers.Max();

        double average = numbers.Average();

        List<int> numbersSorted = new List<int>(numbers);
        numbersSorted.Reverse();
        int smallest = 999999999;
        foreach (int i in numbersSorted)
        {
            if (i > 0 && i < smallest)
                smallest = i;
        }






        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallest}");
        Console.WriteLine($"The sorted list is:");

        numbersSorted.Sort();
        foreach (int i in numbersSorted)
        {
            Console.Write($"{i}, ");
        }
    }
}