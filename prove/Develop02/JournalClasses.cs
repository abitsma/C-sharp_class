using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;
using System.IO;
using System.Xml.Linq;

public class Journal
{
    public List<string> memory = new List<string>();
    public bool running = true;
    public void Run()
    {
        while (running == true)
        {
            PrintMenu();
            Console.Write("\nSelect an option 1 through 5.\n");
            int selection = int.Parse(Console.ReadLine());

            //This is to test that everything works so far. It does.
            if (selection == 1)
            {
                Console.Write("What is today's date?\n");
                string date = Console.ReadLine();
                string prom = prompt();
                Console.WriteLine(prom);
                Console.Write(">\n");
                string test = Console.ReadLine();
                memory.Add($"{date}\n{prom}\n{test} <|>\n");
            }
            else if (selection == 2)
            {
                Console.WriteLine("\n");
                foreach (string entry in memory)
                {
                    Console.WriteLine($"{entry}");
                }
            }
            else if (selection == 3)
            {
                File.Saves(memory);
            }
            else if (selection == 4)
            {
                memory = File.Loads();
            }
            else
            {
                running = false;
            }
        }
    }
    //This will be the menu display I think.
    public void PrintMenu()
    {
        Console.WriteLine("\n--- JOURNAL MENU ---");
        Console.WriteLine("1. Write in Journal.");
        Console.WriteLine("2. Display Journal.");
        Console.WriteLine("3. Save Journal To File.");
        Console.WriteLine("4. Load Journal From File.");
        Console.WriteLine("5. Exit Program.");
    }

    public string prompt()
    {
        List<string> prompts = new List<string>();
        prompts.Add("What was the best interaction you had today?");
        prompts.Add("If today were a song, what song would today be?");
        prompts.Add("You wake up tomorrow and you're turned into a goldfish. What do you do?");
        prompts.Add("What was the most enjoyable part of today?");
        prompts.Add("Share a silly joke.");
        prompts.Add("What makes you mad?");
        prompts.Add("What happened at work?");

        string r_string = prompts[new Random().Next(prompts.Count)];

        return r_string;
    }
}

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
        Console.WriteLine($"File saved to {Path.GetFullPath(filename)}");
    }

    public static List<string> Loads()
    {
        List<string> loading = new List<string>();
        
        Console.Write("What file do you want to load from? (include .txt)\n");
        string l_file = Console.ReadLine();
        string[] idk = System.IO.File.ReadAllLines(l_file);
        
        foreach (string line in idk)
        {
            //Console.WriteLine(line);
            loading.Add(line);
        }

        return loading;
    }
}