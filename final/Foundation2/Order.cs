// Encapsulation with Online Ordering Program    Week 12
// Author : Nelson Mathurent
// Date:    Mar 20, 2023

public class Order
{
    private Customer _customer;
    private List<Product> _productList;

    public Customer GetCustomer() {
        return _customer;
    }
    public void SetCustomerName(Customer customer) {
        _customer = customer;
    }
    public void SetProductList(List<Product> productList) {
        _productList = productList;
    }
    public List<Product> GetProductList() {
        return _productList;
    }

    public Order(Customer customerName, List<Product> productList)
    {
        SetCustomerName(customerName);
        SetProductList(productList);
    }
    public double CalculateTotalCost() {
        Double totalCost = GetShippingCost();
        foreach (Product product in GetProductList())
        {
            totalCost += product.CalculatePrice();
        }
        return totalCost;
    }
    public string CreatePackingLabel(Product product) {
        return $"{product.GetProductID()} - {product.GetName()}     {product.GetQuantity()}     {product.GetPrice()}";
    }
    public string CreateShippingLabel() {
        return $"{GetCustomer().GetCustomerName()}\n{GetCustomer().GetAddress().GetStringAddress()}";
    }
    public void DisplayPackingLabel() {
        foreach (Product product in _productList)
        {
            Console.WriteLine(CreatePackingLabel(product));
        }
    }

    public void DisplayBill() {
        Console.WriteLine("\nShipping to:");
        this.DisplayShippingLabel();
        Console.WriteLine("");
        Console.WriteLine("Product              Qty    Price");
        this.DisplayPackingLabel();
        this.DisplayShippingCost();
        this.DisplayTotalPrice();
        
    }

    public void DisplayShippingLabel() {
        Console.WriteLine(CreateShippingLabel());
    }

    public void DisplayTotalPrice() {
        Console.WriteLine($"Total price: {CalculateTotalCost().ToString("0.00")}");
    }

    public void DisplayShippingCost() {
        Console.WriteLine($"Shipping Cost: {GetShippingCost().ToString("0.00")}");
    }
    public double GetShippingCost() {
        return GetCustomer().LiveInUSA() ? 5.00 : 35.00;
    }
}

