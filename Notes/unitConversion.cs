using System;

class Program
{
    static void Main()
    {
        Console.Write("What is the temperature in F? ");
        string strTemp = Console.ReadLine();
        double fTemp = double.Parse(strTemp);

        double cTemp = (fTemp - 32)*(5.0 / 9.0);
        Console.WriteLine($"Your temperature in C is {cTemp} degrees.");
    }
}