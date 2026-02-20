public class Reference
{
    private string _book;
    private int _chapter;
    private string _verses;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verses = verse.ToString();
    }

    public Reference(string book, int chapter, int verse_start, int verse_end)
    {
        _book = book;
        _chapter = chapter;
        _verses = $"{verse_start}-{verse_end}";
    }

    public void Display()
    {
        Console.WriteLine($"{_book} {_chapter}:{_verses}");
    }
}