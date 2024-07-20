public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetStandardDetails()
    {
        return $"{_title}\n{_description}\n({_date}) - {_time}\n{_address.ReturnStringRepresentation()}";
    }

    public string GetEventType()
    {
        if(this is Lecture)
        {
            return "Lecture Event";
        }
        else if(this is Reception)
        {
            return "Reception Event";
        }
        else if(this is Outdoor)
        {
            return "Outdoor Event";
        }
        else
        {
            return "";
        }
    }

    public void GetFullDetails()
    {
        Console.WriteLine(GetStandardDetails());
        Console.WriteLine(GetEventType());

        if(this is Lecture)
        {
            Console.WriteLine("Speaker: " + (this as Lecture).GetSpeaker());
            Console.WriteLine("Capacity: " + (this as Lecture).GetCapacity());
        }
        else if(this is Reception)
        {
            Console.WriteLine("RSVP: " + (this as Reception).GetEmail());
        }
        else if(this is Outdoor)
        {
            Console.WriteLine("Weather: " + (this as Outdoor).GetWeather());
        }
    }

    public void GetShortDescription()
    {
        Console.WriteLine(GetEventType());
        Console.WriteLine(_title + " - " + _date);
    }
}
