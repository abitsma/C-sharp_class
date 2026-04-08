public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public void OrderCost()
    {
        if (_customer.GetUS() == true)
        {
            int ordercost = 5;
            CodeSaver(ordercost);
        }
        else
        {
            int ordercost = 35;
            CodeSaver(ordercost);
        }
    }

    public void PackingLabel()
    {
        foreach (Product product in _products)
        {
            Console.WriteLine();
            Console.WriteLine(product.GetName());
            Console.WriteLine(product.GetID());
            int quantity = product.GetQuantity();
            Console.WriteLine($"Quantity: {quantity}");
        }
    }

    public void ShippingLabel()
    {
        Console.WriteLine();
        Console.WriteLine(_customer.GetName());
        Console.WriteLine(_customer.GetAddress());
    }

    private void CodeSaver(int ordercost)
    {
        foreach (Product product in _products)
            {
                ordercost = ordercost + product.ProductCost();
            }
            Console.WriteLine();
            Console.WriteLine($"The total Order costs ${ordercost}.");
    }
}