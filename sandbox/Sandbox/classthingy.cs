public class Message
{
    public string _message;
    public int _priority;
    public string GetMessage()
    {
        return $"{_priority}: {_message}";
    }

    public void Ddisplay()
    {
        Console.WriteLine($"{_priority}: {_message}");
    }
}