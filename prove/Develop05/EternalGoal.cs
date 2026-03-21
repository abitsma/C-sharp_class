using System.ComponentModel.DataAnnotations;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        _name = name;
        _description = description;
        _points = points;
        _complete = false;
    }

    public EternalGoal(string name, string description, int points, bool complete) : base(name, description, points, complete)
    {
        _name = name;
        _description = description;
        _points = points;
        _complete = complete;
    }

    public override void Display()
    {
        Console.WriteLine($"[ ] {_name} ({_description})");
    }

    public override int GetScore()
    {
        return _points;
    }

    public override void MarkComplete()
    {
        //do nothing and laugh in the fact eternal goals are never complete
    }

    public override string GetSaveInfo()
    {
        string info = $"EternalGoal<|>{_name}*^*{_description}*^*{_points}*^*{_complete}";
        return info;
    }
}