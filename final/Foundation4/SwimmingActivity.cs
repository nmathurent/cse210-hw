// Inheritance with Event Planning Program    Week 13
// Author : Nelson Mathurent
// Date:    Mar 29, 2023

public class SwimmingActivity : Activity
{
    private int _numberOfLaps;
    
    public double GetNumberOfLaps() {
        return _numberOfLaps;
    }
    public void SetNumberOfLaps(int numberOfLaps) {
        _numberOfLaps = numberOfLaps;
    }

// Constructor 
    public SwimmingActivity(string date, int length, int numberOfLaps) : base(date, length)
    {
        SetNumberOfLaps(numberOfLaps);
    }

    public override double CalculateDistance()
    {
        // Distance (miles) = swimming laps * 50 / 1000 * 0.62
        return ((GetNumberOfLaps() * 50) / 1000 ) * 0.62;
    }
    public override double CalculateSpeed()
    {
        // Speed (mph or kph) = (distance / minutes) * 60
        return (CalculateDistance() / this.GetLength()) * 60;
    }

    public override double CalculatePace()
    {
        // Pace (min per mile or min per km)= minutes / distance
        return this.GetLength() / CalculateDistance();
    }

}

