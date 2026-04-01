using System;

class Program
{
    static void Main(string[] args)
    {
        Address one = new Address("13 E 17 S", "Hiberocombie", "Idaho", "USA");
        Customer Andrew = new Customer("Andrew", one);
        Product WhiteMonster = new Product("White Monster", "WM839234", 2, 24);
        Product Oil = new Product("5W-30 Oil", "O4839202", 32, 1);
        List<Product> AndrewCart = new List<Product>();
        AndrewCart.Add(WhiteMonster);
        AndrewCart.Add(Oil);
        Order AndrewOrder = new Order(Andrew, AndrewCart);

        Address two = new Address("8th Scary Street", "Scarytown", "ScaryProvidence", "ScaryCountry");
        Customer Jack = new Customer("Jack Skellington", two);
        Product Skeleton = new Product("Actual Human Skeleton", "HS4890432", 500, 4);
        Product Pumpkin = new Product("Pumpkin", "P483", 5, 43);
        Product Suit = new Product("Stylish Suit", "SS498042", 100, 1);
        List<Product> JackCart = new List<Product>();
        JackCart.Add(Skeleton);
        JackCart.Add(Pumpkin);
        JackCart.Add(Suit);
        Order JackOrder = new Order(Jack, JackCart);

        List<Order> orders = new List<Order>();
        orders.Add(AndrewOrder);
        orders.Add(JackOrder);

        foreach (Order order in orders)
        {
            order.ShippingLabel();
            order.PackingLabel();
            order.OrderCost();
        }
    }
}