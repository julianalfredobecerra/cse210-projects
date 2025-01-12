using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade percentage? ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int grade))
        {
            string letterGrade = "";

            if (grade >= 90)
            {
                letterGrade = "A";
            }

            else if (grade >= 80)
            {
                letterGrade = "B";
            }

            else if (grade >= 70)
            {
                letterGrade = "C";
            }

            else if (grade >= 60)
            {
                letterGrade = "D";
            }

            else
            {
                letterGrade = "F";
            }

            if (grade >= 70)
            {
                Console.WriteLine($"Congratulations, you passed the class! You got a {letterGrade}");
            }

            else
            {
                Console.WriteLine($"You have failed the class, you got a {grade}. Please take thorough notes during class, do not hesitate to ask for help.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid grade percentage.");
        }
    }
}