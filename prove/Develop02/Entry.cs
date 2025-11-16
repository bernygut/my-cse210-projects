class Entry
{
    // Attributes:
    public string _promptToUser = "";
    public string _promptResponse = "";
    public string _dateStr = "";
    
    //Behaviors:
    public void Prompt_User()
    {
        List<string> prompts = new List<string>();
                prompts.Add("Who was the most interesting person I interacted with today?");
                prompts.Add("What was the best part of my day?");
                prompts.Add("How did I see the hand of the Lord in my life today?");
                prompts.Add("What was the strongest emotion I felt today?");
                prompts.Add("What did the Lord speak to me today?");
                prompts.Add("How did the Savior see my efforts today?");
                prompts.Add("How am I becoming the person I want to be and how can I be better?");
                prompts.Add("Who did I serve as the Savior would?");


                Random randomGenerator = new Random();
                int length = prompts.Count();
                int myRandomlySelectedIndex = randomGenerator.Next(length-1);
                //Console.WriteLine($"myRandomlySelectedIndex: {myRandomlySelectedIndex}");
                string myRandomlySelectedPrompt = prompts[myRandomlySelectedIndex];
                _promptToUser = myRandomlySelectedPrompt;

                Console.WriteLine($"{myRandomlySelectedPrompt}");
                Console.Write(">>");
                _promptResponse = Console.ReadLine();

                DateTime theCurrentTime = DateTime.Now;
                _dateStr = theCurrentTime.ToShortDateString();
    }

}
