using System;

class Program
{
    static void Main(string[] args)
    {
        //obviously the next step would be to create these objects with user input. I'm sure that will be fun. 
        Job job1 = new Job();
        job1._jobTitle = "Inventory Warehouse Manager";
        job1._company = "The Good and the Beautiful";
        job1._startYear = 2021;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._jobTitle = "Software Engineer";
        job2._company = "Bjorn Inventory";
        job2._startYear = 2024;
        job2._endYear = 2024;


        Resume myResume = new Resume();
        myResume._name = "Garrett Stockwell";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

    }
}