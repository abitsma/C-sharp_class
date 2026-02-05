public class Journal
{
    public bool running = true;
    public void Run()
    {
        while (running == true)
        {
            PrintMenu();
            Console.Write("\nSelect an option 1 through 5.\n");
            int selection = int.Parse(Console.ReadLine());
            if (selection != 5)
            {
                //This is to test that everything works so far. It does.
                Console.WriteLine($"\n{selection}");
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
}