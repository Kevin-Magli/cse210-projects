public class Outdoor : Event
{
    private string _weather;

    public Outdoor(string weather, string title, string description, string date, string time, Address address) : base(title, description, date, time, address)
    {
        _weather = weather;
    }
    public string GetWeather()
    {
        return _weather;
    }

}