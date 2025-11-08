using System;
using System.Collections.Concurrent;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random(); 
        int magicNumber = randomGenerator.Next(1,100);
        Boolean Correct = false;

        do
        {

            Console.WriteLine($"What is the magic number? {magicNumber} ");
            Console.Write("What is your guess? ");
            int userNumber = int.Parse(Console.ReadLine());

            if (userNumber < magicNumber)
            {
                Console.WriteLine("Higher.");
            }
            else if (userNumber > magicNumber)
            {
                Console.WriteLine("Lower.");
            }
            else
            {
                Console.Write("You guessed it!");
                Correct = true;
            }
        } while (Correct == false);
    }
}