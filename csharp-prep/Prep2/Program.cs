using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please provide your grade percentage: ");
        int grade = int.Parse(Console.ReadLine());

        if (grade >= 90)
        {
            Console.WriteLine("Your grade is an A.");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("Your grade is a B.");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("Your grade is a C.");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("Your grade is a D.");
        }
        else
        {
            Console.WriteLine("Your grade is an F.");
        }

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You have passed this class.");
        }
        else
        {
            Console.WriteLine("Unfoutunately, you did not pass this class. We encourage you to try again.");
        }

    }
}