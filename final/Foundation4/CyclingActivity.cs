// Inheritance with Event Planning Program    Week 13
// Author : Nelson Mathurent
// Date:    Mar 29, 2023

public class CyclingActivity : Activity
{
    private double _speed;
    
    public double GetSpeed() {
        return _speed;
    }
    public void SetSpeed(double speed) {
        _speed = speed;
    }


// Constructor 
    public CyclingActivity(string date, int length, double speed) : base(date, length)
    {
        SetSpeed(speed);
    }

    public override double CalculateDistance()
    {
        // Distance = Speed × Time
        return GetSpeed() * (this.GetLength() / 60.0);
    }

    public override double CalculateSpeed()
    {
        return GetSpeed();
    }

    public override double CalculatePace()
    {
        // Pace = 60 / speed
        return 60 / GetSpeed();
    }
}

