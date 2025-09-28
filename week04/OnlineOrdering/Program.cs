using System;

class Program
{
    static void Main()
    {
        Address addr1 = new Address("1600 Pennsylvania Ave NW", "Washington", "DC", "USA");
        Address addr2 = new Address("100 South 200 West", "Toronto", "ON", "Canada");

        Customer cust1 = new Customer("John Johnson", addr1);
        Customer cust2 = new Customer("Bob Albert", addr2);

        Product prod1 = new Product("Lefthanded Screwdriver", "100", 10.5, 2);
        Product prod2 = new Product("Gadgetdoer", "101", 5.75, 5);
        Product prod3 = new Product("Thingamajig", "102", 7.0, 3);
        Product prod4 = new Product("Wackadoodad", "103", 12.0, 1);
        Product prod5 = new Product("Whatsitle", "105", 8.25, 4);

        Order order1 = new Order(cust1);
        order1.AddProduct(prod1);
        order1.AddProduct(prod2);
        order1.AddProduct(prod3);

        Order order2 = new Order(cust2);
        order2.AddProduct(prod4);
        order2.AddProduct(prod5);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice()}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice()}");
    }
}
