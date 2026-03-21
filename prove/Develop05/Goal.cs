public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _complete;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _complete = false;
    }

    public Goal(string name, string description, int points, bool complete)
    {
        _name = name;
        _description = description;
        _points = points;
        _complete = complete;
    }

    public abstract void Display();

    public abstract int GetScore();

    public abstract void MarkComplete();

    public abstract string GetSaveInfo();

    public bool IsComplete()
    {
        if (_complete == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}