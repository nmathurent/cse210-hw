using System;

class Program
{
    static void Main(string[] args)
    {
        List<Product> productListOrd = new List<Product>();
        List<Product> productListOrd2 = new List<Product>();

        Console.WriteLine("Welcome to Online Ordering program!");

        // First Order
        Product product1 = new Product("Product one", 201, 10.25, 2);
        productListOrd.Add(product1);
        Product product2 = new Product("Product two", 205, 5.25, 3);
        productListOrd.Add(product2);
        Address address1 = new Address("110 Break Olive st", "Irvine", "CA", "USA");
        Customer customer1 = new Customer("Nelson Mathurent", address1);
        Order order1 = new Order(customer1, productListOrd);
        order1.DisplayBill();

        // Second Order
        Product product3 = new Product("Product 101", 101, 5.25, 2);
        productListOrd2.Add(product3);
        Product product4 = new Product("Product 112", 112, 15.25, 3);
        productListOrd2.Add(product4);
        Product product5 = new Product("Product 103", 103, 50.25, 3);
        productListOrd2.Add(product5);
        Address address2 = new Address("811 Light street", "Lake Forest", "ON", "CAN");
        Customer customer2 = new Customer("Bryan Beaver", address2);
        Order order2 = new Order(customer2, productListOrd2);
        order2.DisplayBill();

    }
}