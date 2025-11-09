using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        int userNumber = -1;
        List<int> numbers = new List<int>();
        float average = 0;
        int sum = 0;
        int count = 0;
        int largest = 0;
        int smallest = 100;

        while (userNumber != 0)
        {
            Console.Write("Enter number:  ");
            userNumber = int.Parse(Console.ReadLine());
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        foreach (int number in numbers)
        {
            sum = sum + number;
            count = count + 1;

            if (number > largest)
            {
                largest = number;
            }
            else if (number < smallest && number > 0)
            {
                smallest = number;
            }
        }


        average = (float)sum / count;

        numbers.Sort();

        Console.WriteLine($"The count is : {count}");
        Console.WriteLine($"The sum is:  {sum}.");
        Console.WriteLine($"The average is:  {average}.");
        Console.WriteLine($"The largest number is:  {largest}.");
        Console.WriteLine($"The smallest number is:  {smallest}.");

        Console.WriteLine($"The ordered list of numbers is: ");
        foreach (int iNumber in numbers)
        {
            Console.WriteLine(iNumber); 
            
        }
    }
}