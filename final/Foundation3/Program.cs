using System;

class Program
{
    static void Main(string[] args)
    {
        Lecture lecture = new Lecture(
            "Bill Gates", 
            300,
            "Mastering C# Programming", 
            "A comprehensive guide to the C# programming language with emphasis on object-oriented principles, syntax, and best practices.", 
            "07/19/2024", 
            "18:00", 
            new Address("123 Main Street", "Classton", "Idaho", "USA")
            );

        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine();

        lecture.GetFullDetails();
        Console.WriteLine();
        
        lecture.GetShortDescription();
        Console.WriteLine();

        Reception reception = new Reception(
            "summer.gala@gmail.com",
            "Summer Gala Reception", 
            "A reception to celebrate the end of the Summer quarter.", 
            "07/20/2024", 
            "16:00", 
            new Address("123 Summer Street", "Suntown", "California", "USA")
            );

        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine();

        reception.GetFullDetails();
        Console.WriteLine();

        reception.GetShortDescription();
        Console.WriteLine();

        Outdoor outdoor = new Outdoor(
            "Sunny 30ºC",
            "Summer Outdoor Festival", 
            "A fun-filled outdoor festival to celebrate the end of the Summer quarter.", 
            "08/01/2024", 
            "10:00", 
            new Address("123 Park Lane", "Sunset City", "California", "USA")
            );

        Console.WriteLine(outdoor.GetStandardDetails());
        Console.WriteLine();

        outdoor.GetFullDetails();
        Console.WriteLine();

        outdoor.GetShortDescription();
        Console.WriteLine();


    }
}