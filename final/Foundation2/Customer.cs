// Encapsulation with Online Ordering Program    Week 12
// Author : Nelson Mathurent
// Date:    Mar 20, 2023

public class Customer
{
    private string _customerName;
    private Address _address;

    public string GetCustomerName() {
        return _customerName;
    }
    public void SetCustomerName(string customerName) {
        _customerName = customerName;
    }

    public Address GetAddress() {
        return _address;
    }
    public void SetAddress(Address address) {
        _address = address;
    }
    public Customer(string customerName, Address address)
    {
        SetCustomerName(customerName);
        SetAddress(address);
    }
    public Boolean LiveInUSA() {
        return true;
    }

}

