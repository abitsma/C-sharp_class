using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        bool _quit = false;
        while (_quit == false)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Breathing Exercise");
            Console.WriteLine(" 2. Reflection Exercise");
            Console.WriteLine(" 3. Listing Exercise");
            Console.WriteLine(" 4. Thoughtfulness Exercise");
            Console.WriteLine(" 5. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Breathing one = new Breathing();
                one.Run();
            }

            else if (choice == "2")
            {
                Reflecting two = new Reflecting();
                two.Run();
            }

            else if (choice == "3")
            {
                Listing three = new Listing();
                three.Run();
            }

            else if (choice == "4")
            {
                Thoughtfulness four = new Thoughtfulness();
                four.Run();
            }

            else if (choice == "5")
            {
                _quit = true;
            }
            
            else
            {
                Console.Clear();
                Console.WriteLine("Please make a valid numerical selection.");
                Thread.Sleep(2000);
                Console.Clear();
            }
        }
        Console.Clear();
        Console.WriteLine("Thank you for using my program!");
    }
}