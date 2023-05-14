using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness app!");

        Console.WriteLine("Please select an activity:");
        Console.WriteLine("1. Breathing exercise");
        Console.WriteLine("2. Reflection");
        Console.WriteLine("3. Listing");

        int activityNumber = int.Parse(Console.ReadLine());

        switch (activityNumber)
        {
            case 1:
                Breathing breathing = new Breathing(60);
                breathing.Start();
                break;
            case 2:
                Reflection reflection = new Reflection(180);
                reflection.Start();
                break;
            case 3:
                Listing listing = new Listing(300);
                listing.Start();
                break;
            default:
                Console.WriteLine("Invalid activity number.");
                break;
        }

        Console.WriteLine("Thank you for using the Mindfulness app!");
    }
}
