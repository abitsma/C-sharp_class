using System;
using System.Net.Http.Headers;

class Program
{
    static void Main(string[] args)
    {
        Fraction dingus = new Fraction();
        Fraction bingus = new Fraction(5);
        Fraction chingus = new Fraction(2, 3);
        dingus.GetTop();
        dingus.GetBottom();
        bingus.GetTop();
        bingus.GetBottom();
        chingus.GetTop();
        chingus.GetBottom();
        dingus.SetTop(6);
        dingus.GetTop();
        Console.WriteLine(dingus.GetFractionString());
        dingus.SetBottom(7);
        Console.WriteLine(dingus.GetDecimalValue());

        int counter = 1;
        Random random = new Random();
        Fraction hingus = new Fraction();
        while (counter <=20)
        {
            int topalicious = random.Next(1, 11);
            hingus.SetTop(topalicious);
            int bottalicious = random.Next(1, 11);
            hingus.SetBottom(bottalicious);
            
            Console.Write($"Fraction {counter}: string: ");
            Console.Write(hingus.GetFractionString());
            Console.Write(" Number: ");
            Console.Write(hingus.GetDecimalValue());
            Console.WriteLine();
            counter++;
        }
    }
}