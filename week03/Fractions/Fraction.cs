using System;

public class Fraction
{
//Create a class to hold fraction.
//The class should be in its own file.
//The class should have two attributes for the top and bottom numbers.
//Make sure the attributes are private.
    private int _top;
    private int _bottom;
    //Constructor that has no parameters that initializes the number to 1/1.
    public Fraction()
    {
    _top = 1;
    _bottom = 1;
    }
    //Constructor that has one parameter for the top and that initializes the denominator to 1. So that if you pass in the number 5, the fraction would be initialized to 5/1.
    public Fraction(int top)
    {
    _top = top;
    _bottom = 1;
    }
    //Constructor that has two parameters, one for the top and one for the bottom.
    public Fraction(int top, int bottom)
    {
    if (bottom == 0)
    {
    throw new ArgumentException("Denominator cannot be zero.");
    }
    _top = top;
    _bottom = bottom;
    }
    //Create getters and setters for both the top and the bottom values.
    public int GetTop()
    {
    return _top;
    }
    public void SetTop(int top)
    {
    _top = top;
    }
    public int GetBottom()
    {
    return _bottom;
    }
    public void SetBottom(int bottom)
    {
    if (bottom == 0)
    {
    throw new ArgumentException("Denominator cannot be zero.");
    }
    _bottom = bottom;
    }
    //Create a method called GetFractionString that returns the fraction in the form 3/4.
    public string GetFractionString()
    {
    return $"{_top}/{_bottom}";
    }
    //Create a method called GetDecimalValue that returns a double that is the result of dividing the top number by the bottom number, such as 0.75.
    public double GetDecimalValue()
    {
    return (double)_top / _bottom;
    }
}