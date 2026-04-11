using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        Console.WriteLine();


        List<Activity> activities = new List<Activity>();

        // Create the activities
        Running a1 = new Running(new DateTime(2022, 11, 3), 30, 4.8);
        activities.Add(a1);

        Cycling a2 = new Cycling(new DateTime(2022, 11, 3), 30, 9.7);
        activities.Add(a2);

        Swimming a3 = new Swimming(new DateTime(2022, 11, 3), 30, 20);
        activities.Add(a3);

        // Display summaries
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}