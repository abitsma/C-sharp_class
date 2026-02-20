public class Scripture
{
    private Reference _reference;
    private List<Word> _text;

    public Scripture(Reference refer, List<Word> words)
    {
        _reference = refer;
        _text = words;
    }

    public List<Word> ShareList()
    {
        return _text;
    }

    public void Display()
    {
        Console.WriteLine("___________________________________________________________________________");
        Console.WriteLine("___________________________________________________________________________");
        Console.WriteLine();
        _reference.Display();
        Console.WriteLine();
        foreach (Word words in _text)
        {
            words.Display();
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("___________________________________________________________________________");
        Console.WriteLine();
        Console.WriteLine("Press enter to continue; type quit to end the program early.");
    }
}