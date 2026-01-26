using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._company = "Google";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 1999;
        job1._endYear = 2005;

        Job job2 = new Job();
        job2._company = "McDonalds";
        job2._jobTitle = "Burger Flipper";
        job2._startYear = 2005;
        job2._endYear = 2025;

        //job1.DisplayJobInfo();
        //job2.DisplayJobInfo();

        Resume resume1 = new Resume();
        resume1._name = "Bob";
        resume1._jobList.Add(job1);
        resume1._jobList.Add(job2);

        //Console.WriteLine(resume1._jobList[0]._jobTitle);
        resume1.DisplayDetails();


    }
}