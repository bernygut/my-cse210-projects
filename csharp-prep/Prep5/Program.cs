using System;

class Program
{
    static void Main(string[] args)
    {
        int birthYearX;
        int squaredNumberX;
        
        DisplayWelcome();
        
        string userNameX = PromptUserName();
        int userNumberX = PromptUserNumber();
        squaredNumberX = SquareNumber(userNumberX);

        PromtUserBirthYear(out birthYearX);

        DisplayResult(userNameX, squaredNumberX, birthYearX);

    }

    // Displays the message, "Welcome to the Program!"
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    //Asks for and returns the user's name (as a string)
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    //Asks for and returns the user's favorite number (as an integer)
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int favoriteNumber = int.Parse(Console.ReadLine());

        return favoriteNumber;
    }

    //Accepts out integer parameter and prompts the user for the year they were born. The out parameter is set to their birth year. This function does not return a value. The user's birth year is given back from the function via the out parameter.

    static void PromtUserBirthYear(out int birthYear)
    {
        Console.Write("Please provide your birh year: ");
        birthYear = int.Parse(Console.ReadLine());
    }

    //Accepts an integer as a parameter and returns that number squared (as an integer)

    static int SquareNumber(int number)
    {
        int numberSquared = number * number;

        return numberSquared;
    } 

    //Accepts the user's name, the squared number, and the user's birth year. 
    //Displays the user's name and squared number. 
    //Calculate how many years old they will turn this year and display that.
    static void DisplayResult(string userName, int squaredNumber, int birthYear)
    {
        Console.WriteLine($"{userName}, the square of your number is {squaredNumber}.");
        int yearsTurning = 2025 - birthYear;
        Console.WriteLine($"{userName}, you will turn {yearsTurning} this year.");
    }
}