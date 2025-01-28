using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        Journal myJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        string filePath = "journal.txt";
        bool isRunning = true;

        while (isRunning)
        {
            DisplayMenu();

            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"\nPrompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();

                    Entry newEntry = new Entry(prompt, response);
                    myJournal.AddEntry(newEntry);
                    Console.WriteLine("Entry added!\n");
                    break;

                case "2":
                    Console.WriteLine("\nJournal Entries:");
                    myJournal.DisplayAll();
                    break;

                case "3":
                    Console.WriteLine("\nLoading entries from file...");
                    myJournal.LoadFromFile(filePath);
                    Console.WriteLine("Entries loaded successfully.\n");
                    break;

                case "4":
                    Console.WriteLine("\nSaving entries to file...");
                    myJournal.SaveToFile(filePath);
                    Console.WriteLine("Entries saved successfully.\n");
                    break;

                case "5":
                    Console.WriteLine("Goodbye!");
                    isRunning = false;
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.\n");
                    break;
            }
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("Welcome to your Journal");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
    }
}