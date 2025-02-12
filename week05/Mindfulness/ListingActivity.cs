using System;
class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", "This activity helps you reflect by listing things in a given category.") { }
    // "Listing" → Sets the _name field in the Activity class.
    //"This activity helps you reflect by listing things in a given category." → Sets the _description field in the Activity class.

    public override void Run()
    {
        DisplayStartingMessage();
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        ShowCountDown(3);
        Console.WriteLine("Start listing items:");
        List<string> items = GetListFromUser();
        Console.WriteLine($"You listed {items.Count} items!");
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
        // rand.Next(_prompts.Count) generates a random number between 0 and _prompts.Count - 1.
        // This random number is used as an index to select an item from _prompts.
        // The selected prompt is returned as the result.
    }

    public List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        int elapsed = 0;
        // elapsed keeps track of how much time has passed in the loop.
        while (elapsed < _duration)
        // The loop runs until the elapsed time reaches the _duration set by the user.
        {
            string input = Console.ReadLine();
            // The program waits for the user to type something and press Enter.
            if (!string.IsNullOrEmpty(input))
                items.Add(input);
            // If the input is not empty, it is added to the items list.
            elapsed += 2;
            // Each iteration adds 2 seconds to elapsed, simulating the passage of time.
        }
        return items;
        // After the loop ends, the list of inputs is returned
    }
}