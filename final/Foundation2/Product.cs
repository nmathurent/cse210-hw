// Encapsulation with Online Ordering Program    Week 12
// Author : Nelson Mathurent
// Date:    Mar 20, 2023

public class Product
{
    private string _name;
    private int _productID;
    private double _price;
    private int _quantity;

    public string GetName() {
        return _name;
    }
    public void SetName(string name) {
        _name = name;
    }
    public int GetProductID() {
        return _productID;
    }
    public void SetProductID(int productID) {
        _productID = productID;
    }
    public double GetPrice() {
        return _price;
    }
    public void SetPrice(double price) {
        _price = price;
    }
    public double GetQuantity() {
        return _quantity;
    }
    public void SetQuantity(int quantity) {
        _quantity = quantity;
    }

// Constructor 
    public Product(string name, int productID, double price, int quantity)
    {
        SetName(name);
        SetProductID(productID);
        SetPrice(price);
        SetQuantity(quantity);
    }
    public double CalculatePrice() {
        return _price * _quantity;
    }

}

