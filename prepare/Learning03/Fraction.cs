using System.Globalization;
using System.Runtime.CompilerServices;

public class Fraction
{
    private int toppy;
    private int botty;

    public Fraction()
    {
        toppy = 1;
        botty = 1;
        Console.WriteLine($"{toppy}/{botty}");
    }

    public Fraction(int wholeNumber)
    {
        toppy = wholeNumber;
        botty = 1;
        Console.WriteLine($"{toppy}/{botty}");
    }

    public Fraction(int top, int bottom)
    {
        toppy = top;
        botty = bottom;
        Console.WriteLine($"{toppy}/{botty}");
    }

    public void GetTop()
    {
        Console.WriteLine(toppy);
    }

    public void SetTop(int top)
    {
        toppy = top;
    }

    public void GetBottom()
    {
        Console.WriteLine(botty);
    }

    public void SetBottom(int bottom)
    {
        botty = bottom;
    }

    public string GetFractionString()
    {
        string a = $"{toppy}/{botty}";
        return a;
    }

    public double GetDecimalValue()
    {
        double b = (toppy + 0.0)/(botty + 0.0);
        return b;
    }
}