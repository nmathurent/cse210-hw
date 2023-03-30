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

    public override double CalculateDistance()
    {
        return GetDistance();
    }

    public override double CalculateSpeed()
    {
        // Speed (mph or kph) = (distance / minutes) * 60
        return (CalculateDistance() / this.GetLength()) * 60;
    }

    public override double CalculatePace()
    {
        // Pace (min per mile or min per km)= minutes / distance
        return this.GetLength() / GetDistance();
    }
}

