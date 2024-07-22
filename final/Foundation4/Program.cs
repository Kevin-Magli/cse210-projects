using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        
        activities.Add(new Running("2022-01-01", 30, 3));
        activities.Add(new Cycling("2022-01-01", 30, 20));
        activities.Add(new Swimming("2022-01-01", 30, 30));

        foreach (Activity activity in activities)
        {
            activity.GetSummary();
        }
    }
}