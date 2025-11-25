class Reference
{
    //Atributes
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;
    
    public Reference()
    {
        _book = "";
        _chapter = 0;
        _startVerse = 0;
        _endVerse = 0;
    }
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = 0;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public string displayReference()
    {
        string completeReference = "";

        if (_endVerse == 0)
        {
            completeReference = String.Concat($"{_book} {_chapter}:{_startVerse}" );
        }
        else
        {
            completeReference = String.Concat($"{_book} {_chapter}:{_startVerse}-{_endVerse}" );
        }

        return completeReference;
    }
}