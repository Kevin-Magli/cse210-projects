using System;

class Program
{
    static void Main(string[] args)
    {
        
        List<Product> products1 = new List<Product>();
        List<Product> products2 = new List<Product>();

        products1.Add(new Product("apple", 1, 10, 0.89f));
        products1.Add(new Product("orange", 2, 2, 1.19f));
        products1.Add(new Product("banana", 3, 5, 0.79f));
        products1.Add(new Product("kiwi", 4, 3, 1.49f));
        Customer customer1 = new Customer("Kevin", new Adress("101 E Viking St", "Rexburg", "Idaho", "USA"));

        products2.Add(new Product("Doritos", 13, 5, 1.99f));
        products2.Add(new Product("Cheetos", 25, 2, 2.49f));
        products2.Add(new Product("Oreos", 31, 5, 2.99f));
        products2.Add(new Product("Snickers", 48, 2, 1.49f));
        products2.Add(new Product("Pringles", 55, 1, 2.79f));
        Customer customer2 = new Customer("Magli", new Adress("Rua das Flores, 100", "São Bernardo do Campo", "São Paulo", "Brazil"));

        Order firstOrder = new Order();
        foreach (Product product in products1)
        {
            firstOrder.AddProduct(product);
        }
        firstOrder.AddCustomer(customer1);
        firstOrder.GetOrderSummary();

        Order secondOrder = new Order();
        foreach (Product product in products2)
        {
            secondOrder.AddProduct(product);
        }
        secondOrder.AddCustomer(customer2);
        secondOrder.GetOrderSummary();
      
    }
}