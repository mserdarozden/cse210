using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Adress adress = new Adress("1234 Elm Street", "Springfield", "Illinois", "USA");
        Customer customer = new Customer("John Heavy", adress);

        Order order1 = new Order(customer);
        
        Product product1 = new Product("Wireless Headphones", 101, 59.99, 15);
        Product product2 = new Product("Smartphone Stand", 102, 19.99, 3);  

        order1.AddProduct(product1);
        order1.AddProduct(product2); 

        Adress adress2 = new Adress("5678 Oak Lane", "London", "Greater London", "England");
        Customer customer2 = new Customer("Jane Light", adress2);

        Order order2 = new Order(customer2);

        Product product3 = new Product("Bluetooth Speaker", 103, 89.99, 5);
        Product product4 = new Product("Portable Charger", 104, 29.99, 20);

        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Console.WriteLine("Order 1");
        Console.WriteLine("-----------------------------");
        Console.WriteLine("Packing Label:");

        List<string> order1PackingLabel = order1.GetPackingLabel();
        foreach (string line in order1PackingLabel)
        {
            Console.WriteLine(line);
        }
        string order1ShippingLabel = order1.GetShippingLabel();
        Console.WriteLine("");
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1ShippingLabel);

        double order1TotalCost = order1.CalculateTotalCost();
        Console.WriteLine("");
        Console.WriteLine("Total Cost:");
        Console.WriteLine($"{order1TotalCost} $");

        Console.WriteLine("");
        Console.WriteLine("Order 2");
        Console.WriteLine("-----------------------------");
        Console.WriteLine("Packing Label:");

        List<string> order2PackingLabel = order2.GetPackingLabel();
        foreach (string line in order2PackingLabel)
        {
            Console.WriteLine(line);
        }
        string order2ShippingLabel = order2.GetShippingLabel();
        Console.WriteLine("");
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2ShippingLabel);

        double order2TotalCost = order2.CalculateTotalCost();
        Console.WriteLine("");
        Console.WriteLine("Total Cost:");
        Console.WriteLine($"{order2TotalCost} $");

       




      
    }
}