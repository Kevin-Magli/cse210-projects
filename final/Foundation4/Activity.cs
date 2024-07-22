public class Activity 
{
    private string _date;
    protected double _length;

    public Activity(string date, double length)
    {
        _date = date;
        _length = length;
    }
    
    public string GetDate()
    {
        return _date;
    }
    public double GetLength()
    {
        return _length;
    }
    public virtual double GetDistance()
    {
        return 0;
    }
    public virtual double GetSpeed()
    {
        return 0;
    }
    public virtual double GetPace()
    {
        return 0;
    }

    public void GetSummary()
    {   
        string activityName = "";

        if (this is Cycling)
        {
            activityName = "Cycling";
        }
        else if (this is Running)
        {
            activityName = "Running";
        }
        else if (this is Swimming)
        {
            activityName = "Swimming";
        }
        else
        {
            activityName =  "";
        }

        Console.WriteLine($"{_date} {activityName} ({_length} min) - Distance: {GetDistance():F2} km, Speed: {GetSpeed():F2} km/h, Pace: {GetPace():F2} min per km");
    }
}