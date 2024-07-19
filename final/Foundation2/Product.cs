public class Product
{
    private string _name;
    private int _id;
    private int _quantity;
    private float _price;

    public Product(string name, int id, int quantity, float price)
    {
        _name = name;
        _id = id;
        _quantity = quantity;
        _price = price;
    }
    
    public float ComputeTotal()
    {
        return _price * _quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetId()
    {
        return _id;
    }
}