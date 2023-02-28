// Polymorphism Learning Activity    Week 09
// Author : Nelson Mathurent
// Date:    Feb 27, 2023

public class Shape
{
    private string _color;
    
    // Constructor that has two parameters, the activity name and the description.
    public Shape(string color)
    {
        _color = color;
    }

    // Method to run the reflecting activity
    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }
    // Method to display the prompt
    public virtual double GetArea()
    {
         return -1;
    }
}