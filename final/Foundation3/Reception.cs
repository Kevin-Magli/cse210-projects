public class Reception : Event
{
    private string _email;

    public Reception(string email, string title, string description, string date, string time, Address address) : base(title, description, date, time, address)
    {
        _email = email;
    }
    public string GetEmail()
    {
        return _email;
    }

}