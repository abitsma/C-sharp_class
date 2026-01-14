using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        //assignment starts here
        //I think my logic is honestly really sketchy but... it works I guess? idk :sob:
        
        Console.WriteLine("What percentage did you get in your class? ");
        string strGrade = Console.ReadLine();
        int intGrade = int.Parse(strGrade);
        string lGrade = "yeehaw";
        int plusmin = intGrade % 10;
        string seeya = ".";

        //Console.WriteLine(plusmin);
        
        if (intGrade > 60 && intGrade < 97)
        {
            if (plusmin <= 3)
            {
                seeya = "-.";
            }
            else if (plusmin >= 7)
            {
                seeya = "+.";
            }
        }

        //Console.WriteLine(intGrade);

        if (intGrade >= 90 && intGrade <= 100)
        {
            //Console.WriteLine("Your letter grade was an A");
            lGrade = "A";
        }
        else if (intGrade >= 80 && intGrade < 90)
        {
            //Console.WriteLine("Your letter grade was a B");
            lGrade = "B";
        }
        else if (intGrade >= 70 && intGrade < 80)
        {
            //Console.WriteLine("Your letter grade was a C");
            lGrade = "C";
        }
        else if (intGrade >= 60 && intGrade < 70)
        {
            //Console.WriteLine("Your letter grade was a D");
            lGrade = "D";
        }
        else if (intGrade < 60 && intGrade >= 0)
        {
            //Console.WriteLine("Your letter grade was a F");
            lGrade = "F";
        }
        else
        {
            Console.WriteLine("Please enter a valid grade.");
            return;
        }

        Console.WriteLine($"Your letter grade was {lGrade}{seeya}");

        if (intGrade >= 70 && intGrade <= 100)
        {
            Console.WriteLine("Congrats! You passed the course.");
        }
        else if (intGrade < 70 && intGrade >= 0)
        {
            Console.WriteLine("You didn't pass, but maybe next time you will!");
        }
        else
        {
            return;
        }
    }
}