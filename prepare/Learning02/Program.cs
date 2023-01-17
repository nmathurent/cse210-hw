using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning02 World!");
        Job job1 = new Job();
        job1._company = "Tesla";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2009;
        job1._endYear   = 2012;

        Job job2 = new Job();
        job2._company = "Microsoft";
        job2._jobTitle = "Software Developer";
        job2._startYear = 2013;
        job2._endYear   = 2023;
        //job1.DisplayJobDetails();
        //job2.DisplayJobDetails();

        // Creating a new instance of the Resume class.
        Resume resumeNel = new Resume();
        resumeNel._name = "Peter Smith";
        resumeNel._jobs.Add(job1);
        resumeNel._jobs.Add(job2);
        // Console.WriteLine(resumeNel._jobs[0]._jobTitle);

        resumeNel.DisplayResumeDetails();
    }
}