using System;
abstract class Activity
{
    // These variables can't be accessed from outside the Activity class
    // But they can be accessed by its subclasses
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        //Clears the console screen, removing all previously printed text.
        Console.Clear();
        Console.WriteLine($"{_name} Activity");
        Console.WriteLine(_description);
        Console.Write("Enter duration (seconds): ");
        // int.Parse converts the string into the integer.
        // Console.ReadLine() waits for the user to enter text and returns it as a string.
        // The converted integer is stored in the _duration variable.
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Good job!");
        Console.WriteLine($"You completed {_name} for {_duration} seconds.");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        // Loop through the given seconds
        for (int i = 0; i < seconds; i++)
        {
            // Print a dot (.) to indicate a loading effect.
            Console.Write(".");
            // Thread.Sleep(1000) makes the program wait for 1000 milliseconds (1 second) before proceeding.
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
    public void ShowCountDown(int seconds)
    {
        // void does not return a value.
        // i = seconds - The countdown starts from the given number.
        // i > 0 - The loop continues until i reaches 1.
        // i-- Decreases i by 1 after each iteration.
        for (int i = seconds; i > 0; i--)
        {
            // The $"{i} " ensures each number appears with a space (e.g., 5 4 3 2 1).
            // No Console.WriteLine() here, so numbers stay on the same line.
            Console.Write($"{i} ");
            // Pauses execution for 1000 milliseconds (1 second).
            // This creates a real-time countdown effect.
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
    public abstract void Run();
    // Forces all subclasses (BreathingActivity, ListingActivity, ReflectingActivity) to provide their own specific implementation of Run().
}