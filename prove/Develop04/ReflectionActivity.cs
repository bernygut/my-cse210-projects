class ReflectionActivity : Activity
{
    public void ExcecuteReflectionActivity()
    {
        Console.WriteLine(base.GetStartMessage());
        int duration = int.Parse(Console.ReadLine());//Get the duration from the user
        base.SetDuration(duration);
        base.SetEndMessage($"You have completed the reflection activity for {duration} seconds.");
        
        List<string> reflectionPrompts= new List<string> 
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless." 
        };


        Console.WriteLine($"");
        Console.WriteLine("Get ready...");
        
        Random random = new Random();
        int randomIndex = random.Next(reflectionPrompts.Count);
        string randomPrompt = reflectionPrompts[randomIndex];

        //Spinner
        base.Spinner(5);




        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"--- {randomPrompt} ---");//Print random prompt
        Console.WriteLine("When you are thinking about something, press enter to continue.");
        Console.ReadLine();

        List<string> reflectionQuestions= new List<string> 
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
        
        int rounds = base.GetDuration()/8;
        
        for (int r = rounds-1; r>=0; r--)
        {
            int randomIndex2 = random.Next(reflectionQuestions.Count);
            string randomQuestion = reflectionQuestions[randomIndex2];
            Console.WriteLine(randomQuestion);
            base.Spinner(8);
        }        

            
            
        Console.WriteLine($"");
        Console.WriteLine($"");

        

        Console.WriteLine("Well done!");
        Console.WriteLine(base.GetEndMessage());       
        base.Spinner(5);

        Console.WriteLine();
    }
}