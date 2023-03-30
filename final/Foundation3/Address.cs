// Inheritance with Event Planning Program    Week 13
// Author : Nelson Mathurent
// Date:    Mar 29, 2023

public class Address
{
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _postalCode;

    public string GetStreet() {
        return _street;
    }
    public void SetStreet(string street) {
        _street = street;
    }
    public string GetCity() {
        return _city;
    }
    public void SetCity(string city) {
        _city = city;
    }
    public string GetStateProvince() {
        return _stateProvince;
    }
    public void SetStateProvince(string stateProvince) {
        _stateProvince = stateProvince;
    }
    public string GetPostalCode() {
        return _postalCode;
    }
    public void SetPostalCode(string postalCode) {
        _postalCode = postalCode;
    }

    public Address(string street, string city, string stateProvince, string postalCode)
    {
        SetStreet(street);
        SetCity(city);
        SetStateProvince(stateProvince);
        SetPostalCode(postalCode);
    }
    public string GetStringAddress() {
        return $"{GetStreet()}\n{GetCity()}, {GetStateProvince()} \n{GetPostalCode()}";
    }
 }

