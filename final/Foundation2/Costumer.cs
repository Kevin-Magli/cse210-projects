public class Customer
{
    private string _name;
    private Adress _adress;

    public Customer(string name, Adress adress)
    {
        _name = name;
        _adress = adress;
    }
    public string GetName()
    {
        return _name;
    }

    public Adress GetAdress()
    {
        return _adress;
    }
    public bool GetTax()
    {
        string country = _adress.GetCountry();
        if (country == "USA")
        {
            return true;
        } else {
            return false;
        }
    }
}