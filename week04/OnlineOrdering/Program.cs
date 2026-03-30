using System;

class Program
{
    static void Main(string[] args)
    {
        // --- Order 1 (In the USA) ---
        Address addr1 = new Address("123 Maple St", "Rexburg", "ID", "USA");
        Customer cust1 = new Customer("Alice Johnson", addr1);
        Order order1 = new Order(cust1);

        order1.AddProduct(new Product("Laptop", "L456", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "M123", 25.50, 2));

        // --- Order 2 (International) ---
        Address addr2 = new Address("456 Lagos Way", "Ikeja", "Lagos", "Nigeria");
        Customer cust2 = new Customer("Ayodeji Adeyera", addr2);
        Order order2 = new Order(cust2);

        order2.AddProduct(new Product("Solar Panel", "S789", 150.00, 3));
        order2.AddProduct(new Product("Battery", "B012", 80.00, 1));

        // --- Display Results ---
        List<Order> orders = new List<Order> { order1, order2 };

        foreach (Order order in orders)
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order.CalculateTotalOrderCost():0.00}");
            Console.WriteLine("----------------------------------\n");
        }
    }
}