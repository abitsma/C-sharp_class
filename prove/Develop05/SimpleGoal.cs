public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _name = name;
        _description = description;
        _points = points;
        _complete = false;
    }

    public SimpleGoal(string name, string description, int points, bool complete) : base(name, description, points, complete)
    {
        _name = name;
        _description = description;
        _points = points;
        _complete = complete;
    }

    public override void Display()
    {
        if (_complete == true)
        {
            Console.WriteLine($"[x] {_name} ({_description})");
        }
        else
        {
            Console.WriteLine($"[ ] {_name} ({_description})");
        }
    }

    public override int GetScore()
    {
        return _points;
    }

    public override void MarkComplete()
    {
        _complete = true;
    }

    public override string GetSaveInfo()
    {
        string info = $"SimpleGoal<|>{_name}*^*{_description}*^*{_points}*^*{_complete}";
        return info;
    }
}