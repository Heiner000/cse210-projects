using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        // job1.Display();


        Job job2 = new Job();
        job2._jobTitle = "Salt Pusher";
        job2._company = "Salt Works";
        job2._startYear = 2023;
        job2._endYear = 2024;

        // job2.Display();

        // Console.WriteLine(job1._company);
        // Console.WriteLine(job2._company);


        Resume myResume = new Resume();
        myResume._name = "Garrett Heiner";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Console.WriteLine(myResume._jobs[1]._jobTitle);

        myResume.Display();

    }
}