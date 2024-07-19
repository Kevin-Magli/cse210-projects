public class Order 
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public float CalculateCost()
    {

        float totalCost = 0f;

        foreach (Product product in _products)
        {   
            totalCost += product.ComputeTotal();
        }

        if (_customer.GetTax())
        {
            return totalCost + 5;
        } else {
            return totalCost + 35;
        }
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public void AddCustomer(Customer customer)
    {
        _customer = customer;
    }
    public void GetOrderSummary()
    {
        Console.WriteLine("Products: ");
        foreach (Product product in _products)
        {
            Console.WriteLine($"{product.GetName()} (ID = {product.GetId()})");
        }
        Console.WriteLine();
        Console.WriteLine($"Customer: {_customer.GetName()} \nAdress: \n{_customer.GetAdress().ReturnStringRepresentation()} \n--Total Cost: ${CalculateCost()}");
    }

}