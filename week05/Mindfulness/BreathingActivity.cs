using System;
class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity helps you relax by guiding your breathing.") { }
    // override: This method overrides the abstract Run() method from the Activity base class.
    public override void Run()
    {
        DisplayStartingMessage();
        // Initializes elapsed to track how long the user has been doing the exercise.
        int elapsed = 0;
        // A while loop ensures the breathing exercise runs until the total elapsed time reaches _duration.
        while (elapsed < _duration)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(3);
            Console.WriteLine("Breathe out...");
            ShowCountDown(3);
            // Since each inhale (3 sec) and exhale (3 sec) together take 6 seconds, we increment elapsed by 6.
            elapsed += 6;
        }
        DisplayEndingMessage();
    }
}