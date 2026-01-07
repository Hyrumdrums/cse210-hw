using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Valve";
        job1._title = "Software Engineer";
        job1._startYear = 2020;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._company = "Nintendo";
        job2._title = "Game Developer";
        job2._startYear = 2018;
        job2._endYear = 2020;

        Resume resume = new Resume();
        resume._name = "Phillip Filop";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        resume.Display();
    }
}