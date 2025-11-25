class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private List<int> _indexesOfHidden;

    public Scripture()
    {
        _reference = new Reference();
        _words = new List<Word>();
        _indexesOfHidden = new List<int>();
    }
    public Scripture(string book, int chapter, int verse, string scriptureWords)
    {
        _reference = new Reference(book, chapter, verse);

        SetWords(scriptureWords);

        _indexesOfHidden = new List<int>();
    }
    public string GetReference()
    {
        string referenceInAString = _reference.displayReference();
        return referenceInAString;
    }
    public string GetWords()
    {
        string allWords = "";
        foreach (Word word in _words)
        {
            allWords += word.GetRenderedText() + " " ;
        }
        allWords = allWords.Trim();
        return allWords;
    }
    private void SetWords(string scriptureWords)
    {
         _words = new List<Word>();
        List<string> tempWords = new List<string>(scriptureWords.Split(" "));
        foreach (string word in tempWords)
        {
           Word newWord = new Word(word);
           _words.Add(newWord);
        }
    }

    public int GetWordsCount()
    {
        return _words.Count();
    }


    public void SetWordHidden(int hiddenIndex)
    {
        _words[hiddenIndex].SetHidden();
    }

    public void SetWordHinted(int hintedIndex)
    {
        _words[hintedIndex].SetHinted();
    }

    public int GetIndexesofHiddenCount()
    {
        return _indexesOfHidden.Count();
    }

    public List<int> GetIndexesofHidden()
    {
        return _indexesOfHidden;
    }

    public void AddToIndexesofHidden(int newIndex)
    {
        if (!_indexesOfHidden.Contains(newIndex))
        {
            _indexesOfHidden.Add(newIndex);
            _indexesOfHidden.Sort();
        }
        ;
    }
}