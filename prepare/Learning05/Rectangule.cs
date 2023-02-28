// Polymorphism Learning Activity    Week 09
// Author : Nelson Mathurent
// Date:    Feb 27, 2023

public class Rectangule: Shape
{
    private int _length;
    private int _width;
    
    // Constructor that has two parameters, the activity name and the description.
    public Rectangule(string color, int length, int width): base(color)
    {
        _length = length;
        _width = width;
    }

    // Method to run the reflecting activity
    public override double GetArea()
    {
        return _length * _width;
    }

}