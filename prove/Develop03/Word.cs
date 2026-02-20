using System.Diagnostics;

public class Word
{
    private string _text;
    private bool _isHidden = false;

    public Word(string word)
    {
        _text = word;
    }

    public void SetHidden()
    {
        _isHidden = true;
    }
    public bool GetHidden()
    {
        return _isHidden;
    }
    public void Display()
    {
        if (_isHidden == false)
        {
            Console.Write($"{_text} ");
        }
        else
        {
            foreach (char letter in _text)
            {
                Console.Write("_");
            }
            Console.Write(" ");
        }
    }
}