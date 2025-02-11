using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");
        Assignment a1 = new Assignment("Stefanny Barragan", "Multiplication");
        Console.WriteLine(a1.GetSummary());

        // Now create the derived class assignments
        MathAssignment a2 = new MathAssignment("Julian Becerra", "Fractions", "7.3", "8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Belen Becerra", "European History", "The Causes of World War II");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}