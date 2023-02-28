// Polymorphism Learning Activity    Week 09
// Author : Nelson Mathurent
// Date:    Feb 27, 2023

public class Shape
{
    private string _color;
    
    // Constructor that has one parameter, the color.
    public Shape(string color)
    {
        _color = color;
    }

    // Method to get the color
    public string GetColor()
    {
        return _color;
    }

    // Method to set the color
    public void SetColor(string color)
    {
        _color = color;
    }
    // Method to calculate the area
    public virtual double GetArea()
    {
         return -1;
    }
}