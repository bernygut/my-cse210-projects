using System;

class Program
{
    static void Main(string[] args)
    {
        int magicNumber = 6;

        Console.WriteLine("What is the magic number? 6 ");
        Console.Write("What is your guess? ");
        int userNumber = int.Parse(Console.ReadLine());

        if (userNumber == magicNumber)
        {
            Console.Write("You guessed it!");
        }
        else if (userNumber < magicNumber)
        {
            Console.WriteLine("Higher.");
        }
        else
        {
            Console.WriteLine("Lower.");
        }
    }
}