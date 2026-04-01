using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> memory = new List<Goal>();
        Points pointmem = new Points();
        int totalpoint;
        bool quit = false;
        while (quit == false)
        {
            totalpoint = pointmem.GetPoints();
            Console.Clear();
            Console.WriteLine($"You have {totalpoint} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Clear();
                bool complete = false;
                while (complete == false)
                {
                    Console.WriteLine();
                    Console.WriteLine("The types of Goals are:");
                    Console.WriteLine(" 1. Simple Goal");
                    Console.WriteLine(" 2. Eternal Goal");
                    Console.WriteLine(" 3. Checklist Goal");
                    Console.Write("Wihch type of goal would you like to create? ");
                    string goaltype = Console.ReadLine();
                    Console.WriteLine();

                    if (goaltype == "1")
                    {
                        Console.Clear();
                        Console.Write("What is the name of your goal? ");
                        string goalname = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("What is a short description of it? ");
                        string goaldesc = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("What is the amount of points associated with this goal? ");
                        bool cach = false;
                        int goalpoints = 0;
                        while (cach == false)
                        {
                            try
                            {
                                goalpoints = int.Parse(Console.ReadLine());
                                cach = true;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine();
                                Console.WriteLine("That's not a valid number. Please try again.");
                            }
                        }
                        SimpleGoal one = new SimpleGoal(goalname, goaldesc, goalpoints);
                        memory.Add(one);
                        complete = true;
                    }

                    else if (goaltype == "2")
                    {
                        Console.Clear();
                        Console.Write("What is the name of your goal? ");
                        string goalname = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("What is a short description of it? ");
                        string goaldesc = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("What is the amount of points associated with this goal? ");
                        bool cach = false;
                        int goalpoints = 0;
                        while (cach == false)
                        {
                            try
                            {
                                goalpoints = int.Parse(Console.ReadLine());
                                cach = true;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine();
                                Console.WriteLine("That's not a valid number. Please try again.");
                            }
                        }
                        EternalGoal two = new EternalGoal(goalname, goaldesc, goalpoints);
                        memory.Add(two);
                        complete = true;
                    }

                    else if (goaltype == "3")
                    {
                        Console.Clear();
                        Console.Write("What is the name of your goal? ");
                        string goalname = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("What is a short description of it? ");
                        string goaldesc = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("What is the amount of points associated with this goal? ");
                        bool cach = false;
                        int goalpoints = 0;
                        while (cach == false)
                        {
                            try
                            {
                                goalpoints = int.Parse(Console.ReadLine());
                                cach = true;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine();
                                Console.WriteLine("That's not a valid number. Please try again.");
                            }
                        }
                        Console.WriteLine();
                        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                        cach = false;
                        int totaltimes = 0;
                        while (cach == false)
                        {
                            try
                            {
                                totaltimes = int.Parse(Console.ReadLine());
                                cach = true;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine();
                                Console.WriteLine("That's not a valid number. Please try again.");
                            }
                        }
                        Console.WriteLine();
                        Console.Write("What is the bonus for accomplishing it that many times? ");
                        cach = false;
                        int bonuspoints = 0;
                        while (cach == false)
                        {
                            try
                            {
                                bonuspoints = int.Parse(Console.ReadLine());
                                cach = true;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine();
                                Console.WriteLine("That's not a valid number. Please try again.");
                            }
                        }
                        ChecklistGoal three = new ChecklistGoal(goalname, goaldesc, goalpoints, totaltimes, bonuspoints);
                        memory.Add(three);
                        complete = true;
                    }

                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Please make a valid numerical selection.");
                        Console.Write("Press enter when you are ready to continue to the next menu. ");
                        Console.ReadLine();

                    }
                }
                
            }

            else if (choice == "2")
            {
                Console.Clear();
                Console.WriteLine("The Goals you have are:");
                foreach (Goal gole in memory)
                {
                    gole.Display();
                }
                Console.Write("Press enter when you are ready to move to the next menu. ");
                Console.ReadLine();
                Console.Clear();

            }

            else if (choice == "3")
            {
                File.Save(totalpoint, memory);
                Console.WriteLine("Goals saved!");
                Console.Write("Press enter when you are ready to move to the next menu. ");
                Console.ReadLine();
                Console.Clear();
            }

            else if (choice == "4")
            {
                Console.Clear();
                Console.Write("What file do you want to load from? (include .txt)\n");
                string filename = Console.ReadLine();
                pointmem.AddPoints(File.LoadPoints(filename));
                memory = File.Load(filename);
                Console.WriteLine("Goals loaded!");
                Console.Write("Press enter when you are ready to move to the next menu. ");
                Console.ReadLine();
                Console.Clear();
            }

            else if (choice == "5")
            {
                if (memory.Count > 0)
                {
                    Console.Clear();
                    Console.WriteLine("The Goals you have are:");
                    int bumber = 1;
                    foreach (Goal gole in memory)
                    {
                        Console.Write($"{bumber}. ");
                        gole.Display();
                        bumber++;
                    }
                    bool flag = false;
                    int goalchoice = 0;
                    while (flag == false)
                    {
                        Console.Write("Which goal did you accomplish? ");
                        try
                        {
                            goalchoice = int.Parse(Console.ReadLine());
                            flag = true;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Please enter a valid selection.");
                        }
                    } 
                    goalchoice--;
                    bool iscomplete = memory[goalchoice].IsComplete();
                    if (iscomplete == false) 
                    {
                        bool checka = false;
                        while (checka == false)
                        {
                            try
                            {
                                memory[goalchoice].MarkComplete();
                                checka = true;
                            }
                            catch (IndexOutOfRangeException)
                            {
                                Console.WriteLine("Please make a valid numerical selection.");
                            }
                        }
                        pointmem.AddPoints(memory[goalchoice].GetScore());
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You've already completed this goal.");
                        Console.Write("Press enter when you are ready to continue to the next menu. ");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Silly Goose, you don't have any goals yet!");
                    Console.Write("Press enter when you are ready to continue to the next menu. ");
                    Console.ReadLine();
                }
            }

            else if (choice == "6")
            {
                quit = true;
            }
            
            else
            {
                Console.Clear();
                Console.WriteLine("Please make a valid numerical selection.");
                Console.Write("Press enter when you are ready to continue to the next menu. ");
                Console.ReadLine();
            }
        }
        Console.Clear();
    }
}