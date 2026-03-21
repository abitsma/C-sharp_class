public class ChecklistGoal : Goal
{
    private int _count = 0;
    private int _total;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int total, int bonus) : base(name, description, points)
    {
        _name = name;
        _description = description;
        _points = points;
        _total = total;
        _bonus = bonus;
        _complete = false;
    }

    public ChecklistGoal(string name, string description, int points, bool complete, int amountcomplete, int total, int bonus) : base(name, description, points, complete)
    {
        _name = name;
        _description = description;
        _points = points;
        _complete = complete;
        _count = amountcomplete;
        _total = total;
        _bonus = bonus;
    }

    public override void Display()
    {
        if (_complete == true)
        {
            Console.WriteLine($"[x] {_name} ({_description}) -- Currently completed: {_total}/{_total}");
        }
        else
        {
            Console.WriteLine($"[ ] {_name} ({_description}) -- Currently completed: {_count}/{_total}");
        }
    }

    public override int GetScore()
    {
        if (_count < _total)
        {
            return _points;
        }
        else if (_count == _total)
        {
            return _points + _bonus;
        }
        else
        {
            return 0;
        }
    }

    public override void MarkComplete()
    {
        if (_count == _total)
        {
            
        }
        else if (_count < _total)
        {
            _count++;
            if (_count == _total)
            {
                _complete = true;
            }
        }
    }

    public override string GetSaveInfo()
    {
        string info = $"ChecklistGoal<|>{_name}*^*{_description}*^*{_points}*^*{_complete}*^*{_count}*^*{_total}*^*{_bonus}";
        return info;
    }
}