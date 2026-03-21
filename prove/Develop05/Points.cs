public class Points
{
    private int _totalpoints = 0;

    public void AddPoints(int add)
    {
        _totalpoints = _totalpoints + add;
    }

    public int GetPoints()
    {
        return _totalpoints;
    }
}