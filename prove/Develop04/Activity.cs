using System;
using System.Collections.Generic;
using System.Threading;

public class Activity
{
    public int Duration { get; set; }
    public string Description { get; set; }
    public string StartingMessage { get; set; }
    public string FinishingMessage { get; set; }
    public string Greeting { get; set; }

    public Activity(int duration)
    {
        Duration = duration;
        Greeting = "Let's get started!";
        StartingMessage = "Starting activity...";
        FinishingMessage = "Activity complete!";
    }

    public virtual void Start()
    {
        Console.WriteLine(StartingMessage);
        Console.WriteLine($"Duration: {Duration} seconds");
        Console.WriteLine(Description);
        Console.WriteLine("Get ready to begin...");
        Thread.Sleep(3000); // Pause for 3 seconds before starting

        DateTime endTime = DateTime.Now.AddSeconds(Duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Time remaining: " + (endTime - DateTime.Now).Seconds + " seconds");
            Thread.Sleep(1000);
        }

        Console.WriteLine(FinishingMessage);
    }
}