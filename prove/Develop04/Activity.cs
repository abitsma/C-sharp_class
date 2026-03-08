public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    protected DateTime _start = new DateTime();
    protected DateTime _end = new DateTime();

    
    public Activity()
    {
        
    }

    public void OpeningDisplay()
    {
        bool cach = false;
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine($"Welcome to the {_name} activity!");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();

        while (cach == false)
        {
            Console.Write("How long, in seconds, would you like your session to be? ");
            try
            {
                _duration = int.Parse(Console.ReadLine());
                cach = true;
            }
            catch (FormatException)
            {
                Console.WriteLine("That's not a valid number. Please try again.");
            }
        }

        Console.Clear();
        Console.WriteLine("Loading your session...");
        Console.WriteLine();
        Spinner();
        Console.WriteLine("Loading complete.");
        Thread.Sleep(1000);
        Console.WriteLine("Prepare to begin your activity.");
        Thread.Sleep(2000);
    }

    public void ClosingDisplay()
    {
        Console.Clear();
        Console.WriteLine("You've finished the activity! Well done :))");
        Thread.Sleep(2000);
        Console.WriteLine($"You have completed {_duration} seconds of the {_name} activity.");
        Thread.Sleep(2000);
        Spinner();
    }

    public static void TimerThing()
    {
        Thread.Sleep(100);
        //Console.Write("\b \b");
        Console.Clear();
    }

    public void Spinner()
    {
        for(int i = 0; i < 7; i++)
        {
            Console.Write("Loading... |");
            TimerThing();
            Console.Write("Loading... /");
            TimerThing();
            Console.Write("Loading... —");
            TimerThing();
            Console.Write(@"Loading... \");
            TimerThing();
        }
    }

    public static void OtherTimerThing()
    {
        Thread.Sleep(500);
        Console.Write("\b \b");
    }

    public void SpinInSpot(int seconds)
    {
        DateTime bart = DateTime.Now;
        DateTime bend = bart.AddSeconds(seconds);
        while (DateTime.Now < bend)
        {
            Console.Write("|");
            OtherTimerThing();
            Console.Write("/");
            OtherTimerThing();
            Console.Write("—");
            OtherTimerThing();
            Console.Write(@"\");
            OtherTimerThing();
        }
    }

    public void DotAnim()
    {
        for (int i = 0; i < 10; i++)
        {   
            Console.Write("Loading O . . .");
            TimerThing();
            Console.Write("Loading . O . .");
            TimerThing();
            Console.Write("Loading . . O .");
            TimerThing();
            Console.Write("Loading . . . O");
            TimerThing();
            Console.Write("Loading . . O .");
            TimerThing();
            Console.Write("Loading . O . .");
            TimerThing();
        }
    }

    public void Counter(int time)
    {
        while (time > 0)
        {
            Console.WriteLine($"{time}...");
            Thread.Sleep(1000);
            time--;
        }
    }

    public void CountInSpot(int time)
    {
        while (time > 0)
        {
            Console.Write($"{time}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            time--;
        }
    }
}