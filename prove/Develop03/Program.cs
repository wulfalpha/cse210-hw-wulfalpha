using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a Scripture object with the reference and text of the verse
        Scripture scripture = new Scripture(new Reference("Book", "Chapter", 1), "This is a *test verse to *memorize.");

        // Main loop of the program
        while (scripture.HasHiddenWords())
        
        {
            // Clear the console and display the reference and text of the verse
            Console.Clear();
            Console.WriteLine(scripture.GetScriptureReference());
            Console.WriteLine(GetMaskedText(scripture));

            // Wait for user input
            string input = Console.ReadLine();

            // If the user types "quit", exit the program
            if (input.ToLower() == "quit")
            {
                break;
            }

            // Remove the first hidden word from the verse
            scripture.RemoveFirstWord();
        }

        // Clear the console and display the reference and complete text of the verse
        Console.Clear();
        Console.WriteLine(scripture.GetScriptureReference());
        Console.WriteLine(GetUnmaskedText(scripture));

        // Wait for user input before closing the program
        Console.ReadLine();
    }
    static string GetMaskedText(Scripture scripture)
    {
        StringBuilder maskedText = new StringBuilder();
        foreach (Word word in scripture._wordList)
        {
            maskedText.Append(word.IsHidden ? new string('*', word.GetWord().Length) : word.GetWord());
            maskedText.Append(' ');
        }
        return maskedText.ToString().TrimEnd();
    }

    static string GetUnmaskedText(Scripture scripture)
    {
        return string.Join(" ", scripture._wordList.Select(word => word.GetWord()));
    }
}
