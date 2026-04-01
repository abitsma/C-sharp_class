public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void Display()
    {
        Console.WriteLine();
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        int numofthing = CommentCount();
        Console.WriteLine($"Number of comments: {numofthing}");
        Console.WriteLine();
        Console.WriteLine("Comments on video");

        foreach (Comment comment in comments)
        {
            comment.Display();
        }
    }

    public int CommentCount()
    {
        int counter = 0;
        foreach (Comment comment in comments)
        {
            counter++;
        }
        return counter;
    }

    public void AddComment(string commenter, string commenttext)
    {
        Comment one = new Comment(commenter, commenttext);
        comments.Add(one);
    }
}