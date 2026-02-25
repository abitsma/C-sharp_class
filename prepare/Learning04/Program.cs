using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment math = new MathAssignment("Austin", "Addition", "1.1", "1-10");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());

        WritingAssignment paper = new WritingAssignment("Austin", "WWII", "How Nazi Germany Lost the Eastern Front");
        Console.WriteLine(paper.GetSummary());
        Console.WriteLine(paper.GetWritingInformation());
    }
}