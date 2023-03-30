// Polymorphism with Exercise Tracking Program    Week 13
// Author : Nelson Mathurent
// Date:    Mar 29, 2023

public class Activity
{
    private string _date;
    private int _length;

    public string GetDate() {
        return _date;
    }
    public void SetDate(string date) {
        _date = date;
    }
    public int GetLength() {
        return _length;
    }
    public void SetLength(int length) {
        _length = length;
    }

// Constructor 
    public Activity(string date, int length)
    {
        SetDate(date);
        SetLength(length);
    }

}

