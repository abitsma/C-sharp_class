using System.ComponentModel.Design;

public class Thoughtfulness : Activity
{
    List<string> _focus = new List<string>();
    public Thoughtfulness()
    {
        _name = "Thoughtfulness";
        _description = "This activity will help you focus by leading you through a guided-thought session.";

        _focus.Add("your breathing.");
        _focus.Add("your heartbeat.");
        _focus.Add("the temperature.");
        _focus.Add("what your hands feel.");
        _focus.Add("your favorite color.");
        _focus.Add("a future goal.");
        _focus.Add("a friend you want to see.");
        _focus.Add("something you want to share.");
        _focus.Add("someone you love.");
        _focus.Add("the feeling of time passing.");
    }

    public void Run()
    {
        OpeningDisplay();
        Console.Clear();

        _start = DateTime.Now;
        _end = _start.AddSeconds(_duration);

        while (DateTime.Now < _end)
        {
            Console.WriteLine();
            string selection = ChoosePrompt();
            Console.Write($"Focus on {selection} ");
            SpinInSpot(15);
            Console.WriteLine();
        }

        ClosingDisplay();
    }

    public string ChoosePrompt()
    {
        Random _random = new Random();
        int point = _random.Next(_focus.Count);
        string choice = _focus[point];
        _focus.RemoveAt(point);
        return choice;
    }
}