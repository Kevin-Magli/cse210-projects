using System;

class Program
{
    static void Main(string[] args)
    {
        var filePath = "activity_counts.csv";
        var breathingCount = 0;
        var reflectingCount = 0;
        var listingCount = 0;

        // Load counts from CSV file
        if (File.Exists(filePath))
        {
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var parts = line.Split(',');
                if (parts[0] == "Breathing")
                    breathingCount = int.Parse(parts[1]);
                else if (parts[0] == "Reflecting")
                    reflectingCount = int.Parse(parts[1]);
                else if (parts[0] == "Listing")
                    listingCount = int.Parse(parts[1]);
            }
        }

        var choice = 0;
        do
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Status");
            Console.WriteLine("  5. Quit");
            Console.Write("  Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
                breathingCount++;
            }
            else if (choice == 2)
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
                reflectingCount++;
            }
            else if (choice == 3)
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
                listingCount++;
            }
            else if (choice == 4)
            {
                Console.WriteLine("Status:");
                Console.WriteLine($"  Breathing activities: {breathingCount}");
                Console.WriteLine($"  Reflecting activities: {reflectingCount}");
                Console.WriteLine($"  Listing activities: {listingCount}");
                Console.Write("Press enter to continue...");
                Console.ReadLine();
            }
        } while (choice != 5);

        // Save counts to CSV file
        using (var writer = new StreamWriter(filePath))
        {
            writer.WriteLine($"Breathing,{breathingCount}");
            writer.WriteLine($"Reflecting,{reflectingCount}");
            writer.WriteLine($"Listing,{listingCount}");
        }
    }
}