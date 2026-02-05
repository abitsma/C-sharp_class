using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string uname = PromptName();
        int unum = PromptNum();
        int uyear = PromptYear();
        int usquar = Square(unum);
        ResultBaby(uname, usquar, uyear);
    }
    static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        static string PromptName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }
        static int PromptNum()
        {
            Console.Write("Please enter your favorite number: ");
            string holup = Console.ReadLine();
            int fnum = int.Parse(holup);
            return fnum;
        }
        static int PromptYear()
        {
            Console.Write("Please enter the year you were born: ");
            string waitamin = Console.ReadLine();
            int year = int.Parse(waitamin);
            return year;
        }
        static int Square(int fnum)
        {
            int squar = fnum*fnum;
            return squar;
        }
        static void ResultBaby(string name, int squar, int year)
        {
            Console.WriteLine($"{name}, the square of your number is {squar}.");
            Console.WriteLine($"{name}, you will turn {2026 - year} this year.");
        }
}