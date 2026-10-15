public class Fraction
{
    private int _top;
    private int _bottom;

    // Constructor 1: Default fraction = 1/1
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor 2: Whole number, denominator = 1
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    // Constructor 3: Top and bottom provided
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

    // Return the fraction as a string
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Return the fraction as a decimal
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}