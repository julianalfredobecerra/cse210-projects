using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public Entry() { }

    public Entry(string promptText, string entryText)
    {
        _date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        _promptText = promptText;
        _entryText = entryText;
    }
    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"{_entryText}");
    }
    public static Entry Parse(string serializedEntry)
    {
        var parts = serializedEntry.Split('|');
        if (parts.Length == 3)
        {
            return new Entry(parts[1], parts[2]) { _date = parts[0] };
        }
        throw new FormatException("Invalid entry format");
    }
}