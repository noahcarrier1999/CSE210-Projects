using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        //Created first instance of the class job
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = "2019";
        job1._endYear = "2022";
        //System.Console.WriteLine(job1._jobTitle);

        //Created a second instance of the class Job
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = "2022";
        job2._endYear = "2023";

        job1.Display();
        job2.Display();

        Resume resume1 = new Resume();
        resume1._name = "Noah Carrier";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        //System.Console.WriteLine(resume1._jobs[0]._jobTitle);
        resume1.Display();
    }
}