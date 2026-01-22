using System;
using System.Globalization;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> batman = new List<int>();
        int inum = 69;
        int total = 0;
        double amount = 0;
        do
        {
            Console.Write("Enter the number you want to add: ");
            string snum = Console.ReadLine();
            inum = int.Parse(snum);
            if (inum !=0)
            {
                batman.Add(inum);
            }
        } while (inum != 0);

        foreach (int number in batman)
        {
            total = total + number;
            amount++;
        }
        Console.WriteLine($"The total of your combined numers is {total}.");
        double average = total / amount;
        Console.WriteLine($"The average of your numbers is {average}.");
        int maximum = batman[0];
        foreach (int bumber in batman)
        {
            if (bumber > maximum)
            {
                maximum = bumber;
            }
        }
        Console.WriteLine($"The biggest number you inputted was {maximum}.");

    }   
}