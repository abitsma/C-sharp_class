using System.Drawing;

public class Reflecting : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>(); 

    public Reflecting()
    {
        _name = "Reflection";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
        _questions.Add("What can you do to add this experience to a part of your character?");
        _questions.Add("What do you thik God thinks about this experience?");
        _questions.Add("Can you recreate this experience in your life?");
    }

    public void Run()
    {
        OpeningDisplay();
        Console.Clear();

        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine(ChoosePrompt());
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter.");
        Console.Write("");
        string pause = Console.ReadLine();

        Console.WriteLine("Now, ponder each of the follow questions as they are related to this experience.");
        Console.WriteLine();
        Console.Write("You may begin in: ");
        CountInSpot(5);
        Console.WriteLine();

        _start = DateTime.Now;
        _end = _start.AddSeconds(_duration);

        while (DateTime.Now < _end)
        {
            Console.WriteLine();
            Console.Write(ChooseQuestion());
            Console.Write(" ");
            SpinInSpot(15);
            Console.WriteLine();
        }

        ClosingDisplay();
    }

    public string ChoosePrompt()
    {
        Random _random = new Random();
        string choice = _prompts[_random.Next(_prompts.Count)];
        return choice;
    }

    public string ChooseQuestion()
    {
        Random _random = new Random();
        int point = _random.Next(_questions.Count);
        string choice = _questions[point];
        _questions.RemoveAt(point);
        return choice;
    }
}