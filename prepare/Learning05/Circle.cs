// Polymorphism Learning Activity    Week 09
// Author : Nelson Mathurent
// Date:    Feb 27, 2023

public class Circle: Shape
{
    private float _radius;
    
    // Constructor that has two parameters, the color name and the radius.
    public Circle(string color, float radius): base(color)
    {
        _radius = radius;

    }

    // Method to calculate the area
    public override double GetArea()
    {
        return Math.PI * (_radius * _radius);
    }

}