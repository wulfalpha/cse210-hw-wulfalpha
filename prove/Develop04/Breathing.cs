using System;
using System.Collections.Generic;
using System.Threading;

public class Breathing : Activity
{
    public Breathing(int duration) : base(duration)
    {
        Description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public override void Start()
    {
        Console.WriteLine(StartingMessage);
        Console.WriteLine($"Duration: {Duration} seconds");
        Console.WriteLine(Description);
        Console.WriteLine("Get ready to begin...");
        Thread.Sleep(3000); // Pause for 3 seconds before starting

        DateTime endTime = DateTime.Now.AddSeconds(Duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(3000); // Pause for 3 seconds while breathing in
            Console.WriteLine("Breathe out...");
            Thread.Sleep(3000); // Pause for 3 seconds while breathing out

            // Display countdown
            TimeSpan remainingTime = endTime - DateTime.Now;
            Console.WriteLine($"Time remaining: {remainingTime.Seconds} seconds");
            Thread.Sleep(1000);
        }

        Console.WriteLine(FinishingMessage);
    }
}
