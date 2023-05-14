using System;
using System.Collections.Generic;
using System.Threading;

public class Listing : Activity
{
    private readonly List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    
    private readonly List<string> _items = new List<string>();

    public Listing(int duration) : base(duration)
    {
        Description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public override void Start()
    {
        Console.WriteLine(Greeting);
        Console.WriteLine(Description);

        // Select a random prompt
        string prompt = _prompts[new Random().Next(0, _prompts.Count)];
        Console.WriteLine($"\nPrompt: {prompt}");

        // Give them a few seconds to begin thinking
        Console.WriteLine("\nStarting in:");
        for (int i = 3; i >= 1; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
        Console.WriteLine("GO!");

        DateTime endTime = DateTime.Now.AddSeconds(Duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("\n> ");
            string response = Console.ReadLine();
            _items.Add(response);
        }

        Console.WriteLine($"\nYou listed {_items.Count} items:");
        for (int i = 0; i < _items.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_items[i]}");
            Thread.Sleep(500);
        }

        Console.WriteLine("\nThat's it for today's listing session. Goodbye!");
    }
}
