using System;
using SodFarm;
//A class is a type of container for variables AND functions
//So just btw
//Public static void Main() is the entrypoint to all of your programming.
//Everything starts there

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello Borld!");
        //In another file, probably bingusclass.cs, I can make a class that does something
        //Okay it looks like there's more to it than just having another file and I think I have to do something w/ creating new programs
        //but idk how to do that so I guess I'll do this in sandbox

        //Message m1 = new Message();
        //m1._message = "Help! I need somebody! (Help!).";
        //m1._priority = 1;

        //Message m2 = new Message();
        //m2._message = "Get some carrots pl0x.";
        //m2._priority = 2;

        //Console.WriteLine(m1.GetMessage());
        //m2.Ddisplay();

        //This is for the car
        //Car myCar = new Car();
        //myCar.Run();

        PlotManager dingus = new PlotManager();
        dingus.Run();
    }
}