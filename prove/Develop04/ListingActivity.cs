class ListingActivity : Activity
{

private List<string> responses = new List<string>();
public void ExcecuteListingActivity()
{
    Console.WriteLine(base.GetStartMessage());
    int duration = int.Parse(Console.ReadLine());//Get the duration from the user
    base.SetDuration(duration);
    base.SetEndMessage($"You have completed the listing activity for {duration} seconds.");
    
    List<string> listingPrompts= new List<string> 
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "Think of a time when you did something truly selfless.",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?" 
    };

    //int rounds = base.GetDuration()/8;


    Console.WriteLine($"");
    Console.WriteLine("Get ready...");

    //Spinner
    base.Spinner(5);  


    Random random = new Random();
    int randomIndex = random.Next(listingPrompts.Count);
    string randomPrompt = listingPrompts[randomIndex];

    Console.WriteLine("List as many responses as you can to the following prompt:");
    Console.WriteLine($"--- {randomPrompt} ---");//Print random prompt

    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(base.GetDuration());
   
    while (DateTime.Now < endTime)
    {
        string newAnswer = Console.ReadLine();
        responses.Add(newAnswer);
        
    }      


    Console.WriteLine("Well done!");
    int responseCount = responses.Count;
    Console.WriteLine($"Congratulations! You have entered {responseCount} responses.");

    // foreach (string s in responses)
    // {
    //     Console.WriteLine(s);
    // }
    
    Console.WriteLine(base.GetEndMessage());       
    base.Spinner(5);

    Console.WriteLine();
    }
}


    