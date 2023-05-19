using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        LevelSystem levelSystem = new LevelSystem();
        FileIO fileIO = new FileIO("goals.xml");

        // Load goals from file
        List<Goal> goals = fileIO.LoadFromFile();
        foreach (Goal goal in goals)
        {
            goalManager.AddGoal(goal);
        }

        while (true)
        {
            Console.WriteLine("------ Goal Tracker ------");
            Console.WriteLine("1. Add Goal");
            Console.WriteLine("2. Complete Goal");
            Console.WriteLine("3. Display Goals");
            Console.WriteLine("4. Save Goals to File");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddGoal(goalManager);
                    break;
                case "2":
                    CompleteGoal(goalManager, levelSystem);
                    break;
                case "3":
                    goalManager.DisplayGoals();
                    break;
                case "4":
                    fileIO.SaveToFile(goalManager.GetGoals());
                    Console.WriteLine("Goals saved to file.");
                    break;
                case "5":
                    // Save goals to file before exiting
                    fileIO.SaveToFile(goalManager.GetGoals());
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void AddGoal(GoalManager goalManager)
    {
        Console.WriteLine("Enter the goal details:");
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Description: ");
        string description = Console.ReadLine();
        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());
        Console.Write("Type (1 - Standard, 2 - Eternal, 3 - Checklist): ");
        int type = int.Parse(Console.ReadLine());

        switch (type)
        {
            case 1:
                goalManager.AddGoal(new StandardGoal(name, description, points));
                Console.WriteLine("Standard goal added.");
                break;
            case 2:
                Console.Write("Completion Bonus: ");
                int completionBonus = int.Parse(Console.ReadLine());
                goalManager.AddGoal(new EternalGoal(name, description, points, completionBonus));
                Console.WriteLine("Eternal goal added.");
                break;
            case 3:
                Console.Write("Number of Stages: ");
                int stages = int.Parse(Console.ReadLine());
                Console.Write("Final Completion Bonus: ");
                int finalCompletionBonus = int.Parse(Console.ReadLine());
                goalManager.AddGoal(new ChecklistGoal(name, description, points, stages, finalCompletionBonus));
                Console.WriteLine("Checklist goal added.");
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }

    static void CompleteGoal(GoalManager goalManager, LevelSystem levelSystem)
    {
        Console.Write("Enter the name of the goal to complete: ");
        string goalName = Console.ReadLine();

        Goal goal = goalManager.SearchGoal(goalName);
        if (goal != null)
        {
            goalManager.CompleteGoal(goal);

            // Level up if enough points accumulated
            if (goal.Points >= levelSystem.Level * 1000)
            {
                levelSystem.IncreaseLevel();
            }
        }
        else
        {
            Console.WriteLine("Goal not found.");
        }
    }
}
