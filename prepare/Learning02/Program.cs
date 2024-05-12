using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Turkish Airlines";
        job1._jobTitle = "First Officer";
        job1._startYear = 2025;
        job1._endYear = 2030;

        Job job2 = new Job();
        job2._company = "Turkish Airlines";
        job2._jobTitle = "Captain";
        job2._startYear = 2030;
        job2._endYear = 2040;

        Resume myResume = new Resume();
        myResume._name = "Serdar Ozden";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();


    }
}
