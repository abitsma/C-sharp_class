using System;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Reference prov = new Reference("Proverbs", 16, 33);
        List<Word> pw = new List<Word>();

        Word The = new Word("The");
        Word lot = new Word("lot");
        Word is1 = new Word("is");
        Word cast = new Word("cast");
        Word into = new Word("into");
        Word the1 = new Word("the");
        Word lap = new Word("lap,");
        Word but = new Word("but");
        Word the2 = new Word("the");
        Word decision = new Word("decision");
        Word is2 = new Word("is");
        Word the3 = new Word("the");
        Word Lords = new Word("Lord's");
        Word alone = new Word("alone.");

        pw.Add(The);
        pw.Add(lot);
        pw.Add(is1);
        pw.Add(cast);
        pw.Add(into);
        pw.Add(the1);
        pw.Add(lap);
        pw.Add(but);
        pw.Add(the2);
        pw.Add(decision);
        pw.Add(is2);
        pw.Add(the3);
        pw.Add(Lords);
        pw.Add(alone);

        Reference alm = new Reference("Alma", 18, 26, 27);
        List<Word> aw = new List<Word>();

        Word And = new Word("And");
        Word then = new Word("then");
        Word Ammon = new Word("Ammon");
        Word said = new Word("said:");
        Word Believest = new Word("Believest");
        Word thou = new Word("thou");
        Word that = new Word("that");
        Word there = new Word("there");
        Word is3 = new Word("is");
        Word a = new Word("a");
        Word Great = new Word("Great");
        Word Spirit = new Word("Spirit?");
        Word And2 = new Word("And");
        Word he = new Word("he");
        Word said2 = new Word("said,");
        Word Yea = new Word("Yea.");

        aw.Add(And);
        aw.Add(then);
        aw.Add(Ammon);
        aw.Add(said);
        aw.Add(Believest);
        aw.Add(thou);
        aw.Add(that);
        aw.Add(there);
        aw.Add(is3);
        aw.Add(a);
        aw.Add(Great);
        aw.Add(Spirit);
        aw.Add(And2);
        aw.Add(he);
        aw.Add(said2);
        aw.Add(Yea);

        Scripture proverbs = new Scripture(prov, pw);
        Scripture alma = new Scripture(alm, aw);

        Console.Write("Type p to work on your Proverbs scripture, type a to work on your Alma scripture.\n");
        string before = Console.ReadLine();
        if (before == "a")
        {
            Run(alma);
        }
        else if (before == "p")
        {
            Run(proverbs);
        }

    }   

    public static int Selection(List<int> list)
    {
        Random random = new Random();
        int index = random.Next(list.Count);
        return index;
    }

    public static void Run(Scripture sc)
    {
        List<int> nums = new List<int>();
        int counter = 0;

        foreach (Word word in sc.ShareList())
        {
            nums.Add(counter);
            counter++;
        }

        while (nums.Count >= 0)
        {
            sc.Display();
            Console.Write("");
            string quit = Console.ReadLine();
            Random couple = new Random();
            int amount = couple.Next(1,4);
            if (quit == "quit")
            {
                break;
            }
            else if (nums.Count == 0)
            {
                break;
            }
            else if (nums.Count == 1 || nums.Count == 2)
            {
                int select = Selection(nums);
                sc.ShareList()[nums[select]].SetHidden();
                nums.RemoveAt(select);
            }
            else
            {
                while (amount > 0)
                {
                    int select = Selection(nums);
                    sc.ShareList()[nums[select]].SetHidden();
                    nums.RemoveAt(select);
                    amount--;
                }
            }
        }
    }
}