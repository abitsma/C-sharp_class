using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> dalist = new List<Activity>();
        Running one = new Running("4/7/2026", 45, 6);
        Bicycle two = new Bicycle("4/8/2026", 50, 20);
        Swimming three = new Swimming("4/9/2026", 15, 32.258064516129035); //I spent a few minutes just sitting here trying numbers to get it to come out to 4mph lol
        dalist.Add(one);
        dalist.Add(two);
        dalist.Add(three);

        foreach (Activity activity in dalist)
        {
            activity.GetSummary();
        }
    }
}