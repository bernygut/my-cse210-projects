using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please provide your grade percentage: ");
        int grade = int.Parse(Console.ReadLine());
        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.Write($"Your grade is a/an {letter}. ");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You have passed this class.");
        }
        else
        {
            Console.WriteLine("Unfortunately, you did not pass this class. We encourage you to try again.");
        }

    }
}