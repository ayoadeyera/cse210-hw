using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // --- Order 1 (USA Customer) ---
        // Create the Address, then the Customer, then the Order.
        Address addr1 = new Address("123 Maple St", "Rexburg", "ID", "USA");
        Customer cust1 = new Customer("Alice Johnson", addr1);
        Order order1 = new Order(cust1);

        // Adding products to the first order
        order1.AddProduct(new Product("Laptop", "L456", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "M123", 25.50, 2));

        // --- Order 2 (International Customer) ---        
        Address addr2 = new Address("456 Lagos Way", "Ikeja", "Lagos", "Nigeria");
        Customer cust2 = new Customer("Ayodeji Adeyera", addr2);
        Order order2 = new Order(cust2);

        // Adding products to the second order
        order2.AddProduct(new Product("Solar Panel", "S789", 150.00, 3));
        order2.AddProduct(new Product("Battery", "B012", 80.00, 1));

        // --- Store orders in a list to iterate through them ---
        List<Order> orders = new List<Order> { order1, order2 };

        // --- Display Results ---
        foreach (Order order in orders)
        {
            Console.WriteLine("----------------------------------");
            // 1. Display the Packing Label
            Console.WriteLine(order.GetPackingLabel());
            
            // 2. Display the Shipping Label
            Console.WriteLine(order.GetShippingLabel());
            
            // 3. Display the Total Price (Shipping is calculated automatically)
            Console.WriteLine($"\nTotal Order Price: ${order.CalculateTotalOrderCost():0.00}");
            Console.WriteLine("----------------------------------\n");
        }
    }
}