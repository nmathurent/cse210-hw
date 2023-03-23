// Encapsulation with Online Ordering Program    Week 12
// Author : Nelson Mathurent
// Date:    Mar 22, 2023

public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public string GetTitle() {
        return _title;
    }
    public void SetTitle(string title) {
        _title = title;
    }
    public string GetDescription() {
        return _description;
    }
    public void SetDescription(string description) {
        _description = description;
    }
    public string GetDate() {
        return _date;
    }
    public void SetDate(string date) {
        _date = date;
    }
    public string GetTime() {
        return _time;
    }
    public void SetTime(string time) {
        _time = time;
    }
    public Address GetAddress() {
        return _address;
    }
    public void SetAddress(Address address) {
        _address = address;
    }
// Constructor 
    public Event(string title, string description, string date, string time, Address address)
    {
        SetTitle(title);
        SetDescription(description);
        SetDate(date);
        SetTime(time);
        SetAddress(address);
    }

}

