using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation2 World!");
        Console.WriteLine("\nIncoming Orders!\n");

        Address address1 = new Address("1600 Pennsylvania Ave", "Washington", "DC", "USA");
        Customer customer1 = new Customer("Joey B", address1);
        Product product1 = new Product("Keyboard", "K1000", 49.99, 1);
        Product product2 = new Product("Toothbrush", "T02500", 9.99, 2);
        Product product3 = new Product("Keyboard Plus", "K2500", 68.75, 1);

        Order order1 = new Order(new List<Product> {product1, product2, product3}, customer1);

        Address address2 = new Address("24 Sussex Dr", "Ottawa", "ON", "Canada");
        Customer customer2 = new Customer("Justin T", address2);
        Product product4 = new Product("Maple Syrup", "M0010", 11.25, 1);
        Product product5 = new Product("Pancake Mix", "P0005", 7.99, 1);
        Product product6 = new Product("Butter", "B0001", 2.99, 7);

        Order order2 = new Order(new List<Product> {product4, product5, product6}, customer2);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"\nTotal: ${order1.GetTotalCostPlusShipping()}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"\nTotal: ${order2.GetTotalCostPlusShipping()}\n");
    }
}