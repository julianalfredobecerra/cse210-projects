using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Video video1 = new Video("C# Basics", "John Doe", 600);
        Video video2 = new Video("OOP in C#", "Alice Smith", 900);
        
        video1.AddComment(new Comment("Mike", "Great video!"));
        video1.AddComment(new Comment("Sara", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Alex", "Can you make one on interfaces?"));

        video2.AddComment(new Comment("Tom", "Awesome explanation!"));
        video2.AddComment(new Comment("Lily", "Super clear examples."));

        video1.DisplayVideoInfo();
        Console.WriteLine();
        video2.DisplayVideoInfo();
    }
}