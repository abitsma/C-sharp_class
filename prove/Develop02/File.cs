public class File
{
    public static void Saves(List<string> s_memory)
    {
        Console.Write("What is the name of the file you want to save to? (include .txt)\n");
        string filename = Console.ReadLine();
        
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (string entry in s_memory)
            {
                outputFile.WriteLine(entry);
            }
        }
        Console.WriteLine($"File saved to {Path.GetFullPath(filename)}.");
    }

    public static List<string> Loads()
    {
        List<string> loading = new List<string>();
        
        Console.Write("What file do you want to load from? (include .txt)\n");
        string l_file = Console.ReadLine();
        string[] gettext = System.IO.File.ReadAllLines(l_file);
        
        foreach (string line in gettext)
        {
            //Console.WriteLine(line);
            loading.Add(line);
        }

        return loading;
    }
}