public class Listing : Activity
{
    private List<string> _prompt = new List<string>();
    private int _counter = 0;

    public Listing()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

        _prompt.Add("Who are people that you appreciate?");
        _prompt.Add("What are personal strengths of yours?");
        _prompt.Add("Who are people that you have helped this week?");
        _prompt.Add("When have you felt the Holy Ghost this month?");
        _prompt.Add("Who are some of your personal heroes?");
        _prompt.Add("What's a blessing you've seen today?");
    }

    public void Run()
    {
        OpeningDisplay();
        Console.Clear();

        Console.WriteLine(ChoosePrompt());
        Console.Write("You may begin the activity in... ");
        CountInSpot(5);
        Console.WriteLine();

        _start = DateTime.Now;
        _end = _start.AddSeconds(_duration);
        while (DateTime.Now < _end)
        {
            Console.Write("");
            Console.ReadLine();
            _counter++;
        }
        

        Thread.Sleep(1000);
        Console.WriteLine($"You have listed {_counter} items! Well done!");
        Thread.Sleep(4000);

        ClosingDisplay();
    }

    public string ChoosePrompt()
    {
        Random _random = new Random();
        string choice = _prompt[_random.Next(_prompt.Count)];
        return choice;
    }
}