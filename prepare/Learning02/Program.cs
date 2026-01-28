using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Coca-Cola";
        job1._jobTitle = "Coke Tester";
        job1._startYear = 2003;
        job1._endYear = 2026;

        Job job2 = new Job();
        job2._company = "Boca-Bola";
        job2._jobTitle = "Boke Bester";
        job2._startYear = 2004;
        job2._endYear = 2025;

        //job1.Display();

        Resume newResume = new Resume();
        newResume._name = "Beter Barker";
        newResume._jobs.Add(job1);
        newResume._jobs.Add(job2);

        newResume.Display();

        
    }
}