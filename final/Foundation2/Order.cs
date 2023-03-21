// Encapsulation with Online Ordering Program    Week 12
// Author : Nelson Mathurent
// Date:    Mar 20, 2023

public class Order
{
    private string _customerName;
    private List<Product> _productList;

    public string GetCustomerName() {
        return _customerName;
    }
    public void SetCustomerName(string customerName) {
        _customerName = customerName;
    }
    public double CalculateTotalPrice() {
        return 0;
    }
    public string CreatePackingLabel() {
        return "";
    }
    public string CreateShippingLabel() {
        return "";
    }
}

