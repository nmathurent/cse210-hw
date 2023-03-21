// Encapsulation with Online Ordering Program    Week 12
// Author : Nelson Mathurent
// Date:    Mar 20, 2023

public class Address
{
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;

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
    public string GetCountry() {
        return _country;
    }
    public void SetCountry(string country) {
        _country = country;
    }

    public string GetStringAddress() {
        return "";
    }
    public Boolean LiveInUSA() {
        return true;
    }
}

