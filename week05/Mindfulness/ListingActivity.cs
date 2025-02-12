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
    }

    public List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        int elapsed = 0;
        while (elapsed < _duration)
        {
            string input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
                items.Add(input);
            elapsed += 2;
        }
        return items;
    }
}