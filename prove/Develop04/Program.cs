using System;
using System.Xml.Serialization;

class Program
{
    private static int _choice = -1;
   

    public static void ChooseAnActivity()
    { 
        
        var breathingInstance1  = new BreathingActivity();
        breathingInstance1.SetStartMessage("Welcome to the Breathing Activity.  This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing. How long, in seconds, would you like for your session?");

        var reflectionInstance1  = new ReflectionActivity();
        reflectionInstance1.SetStartMessage("Welcome to the Reflection Activity. This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your 1ife. How long, in seconds, would you like for your session?");

        var listingInstance1  = new ListingActivity();       
        listingInstance1.SetStartMessage("Welcome to the Listing Activity. This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area. How long, in seconds, would you like for your session?");
        
        var groundingInstance1  = new GroundingActivity();       
        groundingInstance1.SetStartMessage("This exercise helps you anchor yourself in the present moment by engaging your senses.");

        while (_choice !=0)
        {
            Console.WriteLine("Please enter the number corresponding to the activity you wish to complete or 0 to quit: ");
            Console.WriteLine("1. Breathing Activity.");
            Console.WriteLine("2. Reflection Acticty.");
            Console.WriteLine("3. Listing Activity.");
            Console.WriteLine("4. Grounding Activity.");
            Console.WriteLine("0. Quit.");
            int choice = int.Parse(Console.ReadLine());
            
            
            if (choice == 1)
            {
                //Console.WriteLine($"This is choice {choice} - Breathing.");
                breathingInstance1.ExcecuteBreathingActivity();
            }

            else if (choice == 2)
            {
                //Console.WriteLine($"This is choice {choice} - Reflection.");
                reflectionInstance1.ExcecuteReflectionActivity();
            }

            else if (choice == 3)
            {
                //Console.WriteLine($"This is choice {choice} - Listing.");
                listingInstance1.ExcecuteListingActivity();
            }
            
            else if (choice == 4)
            {
                //Console.WriteLine($"This is choice {choice} - Grounding.");
                groundingInstance1.ExcecuteGroundingActivity();
            }
            
            else if (choice == 0)
            {
                _choice = 0;
            }

        }

    }
    
    
    static void Main(string[] args)
    {
        ChooseAnActivity();
    }
}