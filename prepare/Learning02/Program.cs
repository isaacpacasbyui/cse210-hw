using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1._company = "National Polytechnic School";
        job1._jobTitle = "Electrical Engineer";
        job1._startYear = 2015;
        job1._endYear = 2023;


        Job job2 = new Job();

        job2._company = "Empresa Electrica Quito";
        job2._jobTitle = "Finance Manager";
        job2._startYear = 2023;
        job2._endYear = 2026;


        Resume myResume = new Resume();

        myResume._name = "Bryan Calderon";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}