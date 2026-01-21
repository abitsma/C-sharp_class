using System;
using System.ComponentModel;
using System.Dynamic;
using System.Runtime.CompilerServices;

class Program
{
    static void Main()
    {
        int number = 0;
        if (number < 10 && number > -10)
        {
            Console.WriteLine("Your number is single digit.");
        }

        // This is an absolutely disgusting filthy diabolical thing you can do
        //if (number < 10 && number > -10)
        //Console.WriteLine("Yeehaw Cowboy.");

        // You can ALSO do this
        //if (number < 10 && number > -10) Console.WriteLine("This is disgusting");

        else if (number >= 10 || number <= -10)
        {
            Console.WriteLine("Your number is double digit.");
        }

        else
        {
            Console.WriteLine("Idk champ LOL");
        }

        //okay time for some loops
        //While loop, which is the same as Python
        string response = "yes";
        while (response == "yes")
        {
            Console.Write("Do you want to continue? ");
            response = Console.ReadLine();
        }
        Console.WriteLine("Done Cowboy.");

        //This is a do-while loop, which is basically a while loop but cooler idk
        do
        {
            Console.Write("Are you human? ");
            response = Console.ReadLine();
        } while (response == "yes");
        List<string> words = new List<string>();
        words.Add("bingus");
        words.Add("Yeehaw");
        words.Add("idk");

        //This is kinda like the for in python
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }

        //This has 3 secionts inside the parens
        for(int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("");

        //here's a FILTHY infinite loop abusing the code
        //for(;;)Console.WriteLine("bingus");

        for (int dinky = 10; dinky > 0; dinky--)
        {
            Console.WriteLine(dinky);
        }

        //functions now I guess
        void DisplayMessage()
        {
            Console.WriteLine("Hello World!");
        }
        DisplayMessage();

        void Gingus(string name)
        {
            Console.WriteLine($"Hello {name}!");
        }
        Gingus("Sucka");
    }
}