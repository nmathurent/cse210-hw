// Encapsulation with Online Ordering Program    Week 12
// Author : Nelson Mathurent
// Date:    Mar 20, 2023

public class Order
{
    private Customer _customerName;
    private List<Product> _productList;

    public Customer GetCustomerName() {
        return _customerName;
    }
    public void SetCustomerName(Customer customerName) {
        _customerName = customerName;
    }
    public void SetProductList(List<Product> productList) {
        _productList = productList;
    }

    public Order(Customer customerName, List<Product> productList)
    {
        SetCustomerName(customerName);
        SetProductList(productList);
    }
    public double CalculateTotalPrice() {
        return 0;
    }
    public string CreatePackingLabel(Product product) {
        return $"{product.GetProductID()} - {product.GetName()}";
    }
    public string CreateShippingLabel() {
        return "";
    }
    public void DisplayPackingLabel() {
        foreach (Product product in _productList)
        {
            Console.WriteLine(CreatePackingLabel(product));
        }
    }
}

