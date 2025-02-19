using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Activity run = new Running(new DateTime(2022, 11, 3), 30, 3.0);
        
        Activity cycle = new Cycling(new DateTime(2022, 11, 3), 30, 10.0);
        
        Activity swim = new Swimming(new DateTime(2022, 11, 3), 30, 20);

        activities.Add(run);
        activities.Add(cycle);
        activities.Add(swim);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary()); 
        }
    }
}