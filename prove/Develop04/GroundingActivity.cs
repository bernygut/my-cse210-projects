class GroundingActivity : Activity
{

public void ExcecuteGroundingActivity()
{
  
    Console.WriteLine(base.GetStartMessage());

    
    List<string> groundingPrompts= new List<string> 
    {
        "5 things you can see: Look around and name five objects.",
        "4 things you can feel: Notice textures (your clothes, chair, floor).",
        "3 things you can hear: Listen for subtle sounds (clock ticking, distant voices).",
        "2 things you can smell: If nothing obvious, think of a favorite scent.",
        "1 thing you can taste: Maybe the lingering taste in your mouth or sip water." 
    };


    Console.WriteLine($"");
    Console.WriteLine("Get ready...");

    //Spinner
    base.Spinner(3);  


    Console.WriteLine("Notice your surroundings using your senses:");
    int i = groundingPrompts.Count; 
    
    foreach (string prompt in groundingPrompts)
    {
        Console.WriteLine(prompt);
        base.Spinner(i+2);
        base.SetDuration(GetDuration()+i+2);
        i--;
    }

   
    Console.WriteLine("Well done!");

   
    int duration = GetDuration();
    base.SetEndMessage($"You have completed the grounding activity for {duration} seconds.");
    Console.WriteLine(base.GetEndMessage());       
    base.Spinner(5);

    Console.WriteLine();
    }
}


    