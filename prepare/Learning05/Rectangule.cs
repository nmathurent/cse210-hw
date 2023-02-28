// Polymorphism Learning Activity    Week 09
// Author : Nelson Mathurent
// Date:    Feb 27, 2023

public class Rectangule: Shape
{
    private int _length;
    private int _width;
    
    // Constructor that has three parameters, the color, the length and the width.
    public Rectangule(string color, int length, int width): base(color)
    {
        _length = length;
        _width = width;
    }

    // Method to calculate the area
    public override double GetArea()
    {
        return _length * _width;
    }

}