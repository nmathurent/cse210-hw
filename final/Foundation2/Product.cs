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

    public double CalculatePrice() {
        return 0;
    }

}

