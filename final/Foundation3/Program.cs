using System;

class Program
{
    static void Main(string[] args)
    {
        Address one = new Address("17 Thumper St.", "Moab", "UT", "USA");
        Address two = new Address("8 Juniper Way", "Idaho Falls", "Idaho", "USA");
        Address three = new Address("60 Brazil Rd.", "Rio", "Rio de Janeiro", "Brazil");

        Lecture uno = new Lecture("What to do in your 20's", "an event that teaches young adults how to have fun while also getting their life together", "4/1/2026", "6:00 PM", one, "John Sermon", 250);
        Reception dos = new Reception("The Wedding Reception of Jess Snyder and Jerard Nutterback", "a party to celebrate the wedding recpetion of Jess Snyder and Jerard Nutterback", "9/5/2026", "5:00 PM", two, "JS+JN4eva@gmail.com");
        Outdoor tres = new Outdoor("Carnival", "the awesome Brazilian festival where you drink and party", "2/5/27", "8:00 AM - 12:00 PM", three, "sunny and warm");

        List<Event> lista = new List<Event>();
        lista.Add(uno);
        lista.Add(dos);
        lista.Add(tres);

        foreach (Event thing in lista)
        {
            Console.WriteLine(thing.StandardDetails());
            Console.WriteLine();
            Console.WriteLine(thing.FullDetails());
            Console.WriteLine();
            Console.WriteLine(thing.ShortDescription());
            Console.WriteLine();
        }
    }
}