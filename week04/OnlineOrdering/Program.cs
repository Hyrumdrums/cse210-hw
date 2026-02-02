using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("USA Customer\n");
        Address address1 = new Address("123 Cany Lane", "My Town", "CA", "USA");
        Customer customer1 = new Customer("Chris Cringle", address1);
        Order order1 = new Order(customer1);
        Product product1 = new Product("Tie", "t001", 25.99, 1);
        Product product2 = new Product("Cheap Tie", "t002", 19.99, 2);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():0.00}");

        Console.WriteLine("\n");
        Console.WriteLine("International Customer\n");
        Address address2 = new Address("123 Elm St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Maple Customer", address2);
        Order order2 = new Order(customer2);
        Product product3 = new Product("Sweater", "s001", 49.99, 1);
        Product product4 = new Product("Hat", "h001", 15.99, 3);
        order2.AddProduct(product3);
        order2.AddProduct(product4);
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():0.00}");
    }
}