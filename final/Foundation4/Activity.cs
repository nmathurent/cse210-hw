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

    public virtual double CalculateDistance()
    {
        return 0;
    }

    public virtual double CalculateSpeed()
    {
        return 0;
    }

    public virtual double CalculatePace()
    {
        return 0;
    }

    public void GetSummary()
    {
        Console.WriteLine($"{this.GetDate()} {this.GetType().ToString().Replace("Activity", "")} ({this.GetLength()} min)- Distance {this.CalculateDistance().ToString("0.0")} miles, Speed {this.CalculateSpeed().ToString("0.0")} mph, Pace: {this.CalculatePace().ToString("0.0")} min per mile");
    }

}

