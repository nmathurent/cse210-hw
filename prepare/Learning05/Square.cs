// Polymorphism Learning Activity    Week 09
// Author : Nelson Mathurent
// Date:    Feb 27, 2023

public class Square: Shape
{
    private int _side;
    
    // Constructor that has two parameters, the activity name and the description.
    public Square(string color, int side): base(color)
    {
        _side = side;
    }

    // Method to run the reflecting activity
    public override double GetArea()
    {
        return _side * _side;
    }

}