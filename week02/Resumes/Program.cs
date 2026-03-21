using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

// Create individual Job objects
        Job job1 = new Job();
        job1._jobTitle = "Junior Software Developer";
        job1._company = "Microsoft";
        job1._startYear = "2022";
        job1._endYear = "2023";

        Job job2 = new Job();
        job2._jobTitle = "Senior Software Developer";
        job2._company = "Facebook";
        job2._startYear = "2024";
        job2._endYear = "2026";


// Create Resume object
        Resume myResume = new Resume();
        myResume._name = "Solomon Adeyera";

// Add the jobs to the list inside resume        
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

// Display the resume
        myResume.Display();




    }
}