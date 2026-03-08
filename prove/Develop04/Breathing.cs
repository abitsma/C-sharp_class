public class Breathing : Activity
{
    public Breathing()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
        OpeningDisplay();
        Console.Clear();
        
        _start = DateTime.Now;
        _end = _start.AddSeconds(_duration);
        while (DateTime.Now < _end)
        {
            Console.Clear();
            Console.WriteLine("Breathe in");
            Counter(5);
            Console.Clear();
            Console.WriteLine("Breathe out");
            Counter(5);
        }

        ClosingDisplay();
    }

}