using System;
using System.Collections.Generic;
using System.Threading;

public class Reflection : Activity
{
    private readonly List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private readonly List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public Reflection(int duration) : base(duration)
    {
        Description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public override void Start()
    {
        Console.WriteLine(StartingMessage);
        Console.WriteLine(Description);
        Console.WriteLine("Let's reflect on some experiences:");

        DateTime endTime = DateTime.Now.AddSeconds(Duration);

        while (DateTime.Now < endTime)
        {
            // Display countdown
            TimeSpan remainingTime = endTime - DateTime.Now;
            Console.WriteLine($"\nTime remaining: {remainingTime.Seconds} seconds");

            // Display a random prompt
            string prompt = _prompts[new Random().Next(0, _prompts.Count)];
            Console.WriteLine($"\nPrompt: {prompt}");

            // Display all the questions for the prompt
            foreach (string question in _questions)
            {
                Console.Write($"{question} ");
                Thread.Sleep(2000);
                Console.Write(". ");
                Thread.Sleep(1000);
            }

            Console.WriteLine();
        }

        Console.WriteLine(FinishingMessage);
    }
}
