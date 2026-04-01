public class Comment
{
    private string _name;
    private string _text;

    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }
    
    public void Display()
    {
        Console.WriteLine();
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Comment: {_text}");
    }
}