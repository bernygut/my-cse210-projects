class BreathingActivity : Activity
{
  
    public void ExcecuteBreathingActivity()
    {
        Console.WriteLine(base.GetStartMessage());
        int duration = int.Parse(Console.ReadLine());//Get the duration from the user
        base.SetDuration(duration);
        SetEndMessage($"You have completed the breathing activity for {duration} seconds.");
        
        int rounds = base.GetDuration()/6;
        
        Console.WriteLine($"");
        Console.WriteLine("Get ready to breathe in and then out...");
        
        //Spinner
        base.Spinner(5);

        for (int r = rounds-1; r>=0; r--)
        {
            //Run breathe in and out
            Console.Write($"Breathe in..."); 
            for (int i = 3; i>0; i--)
            {
                Console.Write(i); 
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine($"");
            Thread.Sleep(1000);
            

            Console.Write($"Breathe out..."); 
            for (int i = 3; i>0; i--)
            {
                Console.Write(i); 
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Thread.Sleep(1000);
            
            
            Console.WriteLine($"");
            Console.WriteLine($"");

        } 

        Console.WriteLine("Well done!");
        Console.WriteLine(base.GetEndMessage());
        base.Spinner(3);
        Console.WriteLine();
    }


}