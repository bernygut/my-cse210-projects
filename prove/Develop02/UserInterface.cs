class UserInterface
{
    //Attributes:
    public int _userSelection = 0;
    public Journal _theCurrentJournal = new Journal();

    //Behaviors:
    void DisplayMenu()
    {
        /*
        Displays options:
        1. Write a new entry - Show the user a random prompt (from a list that you create), and save their response, the prompt, and the date as an Entry.
        2. Display the journal - Iterate through all entries in the journal and display them to the screen.
        3. Save the journal to a file - Prompt the user for a filename and then save the current journal (the complete list of entries) to that file location.
        4. Load the journal from a file - Prompt the user for a filename and then load the journal (a complete list of entries) from that file. This should replace any entries currently stored in the journal.
        5. Search for keyword(s) in journal.
        6. Quit */

        Console.WriteLine("1. Write a new entry.");
        Console.WriteLine("2. Display the journal.");
        Console.WriteLine("3. Save the journal to a file.");
        Console.WriteLine("4. Load the journal from a file");
        Console.WriteLine("5. Search for keyword(s) in journal");
        Console.WriteLine("6. Quit");

        Console.Write("Please make a selection from the options above: ");
        _userSelection = int.Parse(Console.ReadLine());
    }
    public void GetAndExecuteOption()
    {
        while (_userSelection != 6)
        {
            DisplayMenu();
            if (_userSelection == 1)
            {
                Entry newEntry = new Entry();
                newEntry.Prompt_User();
                _theCurrentJournal.entries.Add(newEntry);

            }

            else if (_userSelection == 2)
            {
                //Display the Journal
                _theCurrentJournal.Display();

            }

            else if (_userSelection == 3)
            {
                //Save the Journal to a file
                _theCurrentJournal.Save();

            }

            else if (_userSelection == 4)
            {
                //Load the Journal from a file
                _theCurrentJournal.Load();
            }

            else if (_userSelection == 5)
            {
                //Search for keyword(s) in Journal
                _theCurrentJournal.Search();
            }
            
        }
    }
    
}