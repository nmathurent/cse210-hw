using System;

class Program
{
    static void Main(string[] args)
    {
        List<Product> productListOrd = new List<Product>();

        Console.WriteLine("Welcome to Online Ordering program!");
        Product product1 = new Product("Product one", 1, 10.25, 2);
        productListOrd.Add(product1);
        Product product2 = new Product("Product two", 2, 5.25, 3);
        productListOrd.Add(product2);
        Address address1 = new Address("110 Break Olive st", "Irvine", "CA", "USA");
        Customer customer1 = new Customer("Nelson Mathurent", address1);
        Order order1 = new Order(customer1, productListOrd);
        order1.DisplayPackingLabel();

    }
}