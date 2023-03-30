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
        // Distance (km) = swimming laps * 50 / 1000
        return (GetNumberOfLaps() * 50) / 1000;
    }
}

