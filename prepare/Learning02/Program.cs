using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Fiserv";
        job1._jobTitle = "Director of Security";
        job1._startYear = 2009;
        job1._endYear = 2021; 

        Job job2 = new Job();
        job2._company = "Microsoft";
        job2._jobTitle = "Senior Program Manager";
        job2._startYear = 2021;
        job2._endYear = 2100;


        Resume myResume = new Resume();
        myResume._name = "Berny Gutierrez";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.Display();
    }
}