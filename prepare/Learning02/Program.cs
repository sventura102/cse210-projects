using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Patient Associate";
        job1._company = "Shepherd Eye Center";
        job1._startYear = 2019;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._jobTitle = "Program Supervisor";
        job2._company = "Safekey";
        job2._startYear = 2023;
        job2._endYear = 2023;

        Resume resume = new Resume();
        resume._name = "Stephanie Ventura";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();
    }
}