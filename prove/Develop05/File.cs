using System.Drawing;
using System.IO;
using System.Collections.Generic;
public class File
{
    public static void Save(int points, List<Goal> goles)
    {
        Console.Clear();
        Console.Write("What is the name of the file you want to save to? (include .txt)\n");
        string filename = Console.ReadLine();
        
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(points);
            foreach (Goal gole in goles)
            {
                string convert = gole.GetSaveInfo();
                outputFile.WriteLine(convert);
            }
        }
        Console.WriteLine($"File saved to {Path.GetFullPath(filename)}.");
    }

    public static int LoadPoints(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        int points = int.Parse(lines[0]); 
        return points;
    }

    public static List<Goal> Load(string filename)
    {
        List<Goal> loader = new List<Goal>();
        string[] lines = System.IO.File.ReadAllLines(filename);

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split("<|>");
            string goalType = parts[0];
            string goalData = parts[1];
            string[] dataPieces = goalData.Split("*^*");

            if (goalType == "SimpleGoal")
            {
                string name = dataPieces[0];
                string description = dataPieces[1];
                int points = int.Parse(dataPieces[2]);
                bool complete = bool.Parse(dataPieces[3]);
                
                SimpleGoal one = new SimpleGoal(name, description, points, complete);
                loader.Add(one);
            }

            else if (goalType == "EternalGoal")
            {
                string name = dataPieces[0];
                string description = dataPieces[1];
                int points = int.Parse(dataPieces[2]);
                bool complete = bool.Parse(dataPieces[3]);

                EternalGoal two = new EternalGoal(name, description, points, complete);
                loader.Add(two);
            }

            else if (goalType == "ChecklistGoal")
            {
                string name = dataPieces[0];
                string description = dataPieces[1];
                int points = int.Parse(dataPieces[2]);
                bool complete = bool.Parse(dataPieces[3]);
                int amountdone = int.Parse(dataPieces[4]);
                int total = int.Parse(dataPieces[5]);
                int bonus = int.Parse(dataPieces[6]);

                ChecklistGoal three = new ChecklistGoal(name, description, points, complete, amountdone, total, bonus);
                loader.Add(three);
            }
        }
        return loader;
    }
}