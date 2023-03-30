using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Activity> activityList = new List<Activity>();
        RunningActivity rActivity = new RunningActivity("03 Nov 2022", 30, 3.0);
        activityList.Add(rActivity);
        CyclingActivity cActivity = new CyclingActivity("13 Dec 2022", 30, 6.0);
        activityList.Add(cActivity);
        SwimmingActivity sActivity = new SwimmingActivity("23 Dec 2022", 20, 10);
        activityList.Add(sActivity);

        foreach (Activity activity in activityList)
        {
            activity.GetSummary();
        }

    }
}