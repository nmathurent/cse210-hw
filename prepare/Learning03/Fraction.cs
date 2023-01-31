// Encapsulation Learning Activity    Week 05
// Author : Nelson Mathurent
// Date:    Jan 30, 2023

public class Fraction
{
    private int _top;
    private int _bottom;

    // Constructor that has no parameters that initializes the number to 1/1.
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor that has one parameter for the top and that initializes the 
    // denominator to 1.
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    // Constructor that has two parameters, one for the top and one for the bottom.
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getter for top
    public int GetTop()
    {
        return _top;
    }

    // Setter for top
    public void SetTop(int top)
    {
        _top = top;
    }

        // Getter for bottom
    public int GetBottom()
    {
        return _bottom;
    }

    // Setter for bottom
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // Returns the fraction in the form 3/4
    public string GetFractionString()
    {
        return _top + "/" + _bottom;
    }

    // Returns the fraction in the form 3/4
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }

}