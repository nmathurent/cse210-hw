// Inheritance with Event Planning Program    Week 13
// Author : Nelson Mathurent
// Date:    Mar 29, 2023

public class RunningActivity : Activity
{
    private double _distance;
    
    public double GetDistance() {
        return _distance;
    }
    public void SetDistance(double distance) {
        _distance = distance;
    }


// Constructor 
    public RunningActivity(string date, int length, double distance) : base(date, length)
    {
        SetDistance(distance);
    }

}

