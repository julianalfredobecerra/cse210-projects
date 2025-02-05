using System;
using System.Net;
using System.Transactions;

class Video{

    public string _title;
    public string _author;
    public int _LenghtInSeconds;
    private List<Comment> Comments;

    public Video(string title, string author, int lenghtInSeconds)
    {
        _title = title;
        _author = author;
        _LenghtInSeconds = lenghtInSeconds;
        Comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        // First you put the name of the List and then .Add to add
        // an element to that list.
        Comments.Add(comment);
    }

    public int GetCommentCount()
    {
        // This is the way to count the elements on a list. By first returning
        // the list and then .Count will count the elements.
        return Comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Lenght: {_LenghtInSeconds} seconds");
        Console.WriteLine($"Comments ({GetCommentCount()}):");
        // foreach is a loop that goes through each item in the list.
        foreach(var comment in Comments)
        {
            // var comment means that for each iteration, 
            // comment represents a single item from the Comments list.
            Console.WriteLine($" - {comment._name}: {comment._text}");
        }
    }
}