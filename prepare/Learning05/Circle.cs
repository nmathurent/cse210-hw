// Polymorphism Learning Activity    Week 09
// Author : Nelson Mathurent
// Date:    Feb 27, 2023

public class Circle: Shape
{
    private float _radius;
    
    // Constructor that has two parameters, the activity name and the description.
    public Circle(string color, float radius): base(color)
    {
        _radius = radius;

    }

    // Method to run the reflecting activity
    public override double GetArea()
    {
        return Math.PI * (_radius * _radius);
    }

}