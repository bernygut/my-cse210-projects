class Activity
{
    private int _duration = 0;    
    private string _startMessage = "";  
    private string _endMessage = "";
    private List<string> _prompts = new List<string>();

    public int GetDuration()
    {
        return _duration;
    }
    public string GetEndMessage()
    {
        return _endMessage;
    }
    public string GetStartMessage()
    {
        return _startMessage;
    }
    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    public void SetEndMessage(string endMessage)
    {
        _endMessage = endMessage;
    }

    public void SetStartMessage(string startMessage)
    {
        _startMessage = startMessage;
    }


    public void Spinner(int numberOfSeconds)
    {
        List<string> animationElements = new List<string> {"|", "/", "-", "\\", "|", "/", "-", "\\"};

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(numberOfSeconds);
   
        int i = 0;     

        while (DateTime.Now < endTime)
        {
            string e = animationElements[i];
            Console.Write(e);
            Thread.Sleep(800);
            Console.Write("\b \b");

            i++;

            if (i >= animationElements.Count)
            {
                i = 0;
            }
        }

    }
    
}