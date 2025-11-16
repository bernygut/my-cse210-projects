using System.Collections.Generic;
using System.IO; 

class Journal
{
    //Attributes:
    public List<Entry> entries = new List<Entry>();

    //Behaviors:
    public void Save()
    {
        //Saves Journal to file 
        Console.Write("What is the file name?");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in entries)
            {
                outputFile.WriteLine($"{entry._dateStr},{entry._promptToUser},{entry._promptResponse}");
            }         
        }


    }
    public void Load()
    {
        //Loads Journal from a file 
        Console.Write("What is the file name?");
        string fileName = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(fileName);

        entries = new List<Entry>();
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            Entry thisEntry = new Entry();
            thisEntry._dateStr = parts[0];
            thisEntry._promptToUser = parts[1];
            thisEntry._promptResponse = parts[2];

            entries.Add(thisEntry);

        }
    }
    public void Display()
    {
        //Display the Journal
        foreach (Entry entry in entries)
        {
            Console.WriteLine($"{entry._dateStr} - Prompt: {entry._promptToUser}");
            Console.WriteLine($"Response: {entry._promptResponse}");
        }
    }
    public void Search()
    {
        Console.Write("Please provide the keyword(s) you are looking for?");
        string keyword = Console.ReadLine();
        int apperanceCount = 0;
        foreach (Entry entry in entries)
        {
            if (entry._promptToUser.Contains(keyword) || entry._promptResponse.Contains(keyword))
            {
                if (apperanceCount == 0)
                {
                    Console.WriteLine("The following entries were found: ");
                }
                
                Console.WriteLine($"{entry._dateStr} - Prompt: {entry._promptToUser}");
                Console.WriteLine($"Response: {entry._promptResponse}");
                apperanceCount += 1;
            }
        if (apperanceCount == 0)
        {
            Console.WriteLine("The keyword(s) was not found!");        
        }
        }         
    }
}
