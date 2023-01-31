using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        // Create fractions using all three constructors
        Fraction f1 = new Fraction(); // Don't pass any information to get the default values 1/1
        Fraction f2 = new Fraction(6); // Passing only one parameter for the top 
        Fraction f3 = new Fraction(6,7); // Passing two parameters, one for the top and one for the bottom
        Fraction f4 = new Fraction();

        // Verifying that I can call the getters and setters methods and displaying
        // the values to the console.
        Console.WriteLine("Top before changing the value to 3: " + f1.GetTop());
        f1.SetTop(3);
        Console.WriteLine("Top after changing the value to 3: " + f1.GetTop());

        Console.WriteLine("Bottom before changing the value to 7: " + f1.GetBottom());
        f1.SetBottom(7);
        Console.WriteLine("Bottom after changing the value to 7: " + f1.GetBottom());

        // Display different representations for a few different fractions
        Console.WriteLine($"\nDisplaying different representations for a few different fractions");
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());
        f2.SetTop(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());
        f3.SetTop(3);
        f3.SetBottom(4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());
        f4.SetBottom(3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

    }
}