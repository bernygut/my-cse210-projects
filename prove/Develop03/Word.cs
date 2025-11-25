class Word
{
    private string _plainText;
    private string _hiddenText;
    private string _hintedText;
    private bool _hidden;
    private bool _hinted;
  

    public Word (string wordText)
    {
        _plainText = wordText;
        _hiddenText = new string('_', _plainText.Length);
        char _hintFirst = _plainText[0];
        string _hintHidden = new string('_', _plainText.Length-1);
        _hintedText = string.Concat(_hintFirst, _hintHidden);
        _hidden = false;
        _hinted = false;
    }

    public string GetRenderedText()
    {
        if (!_hidden && !_hinted)
        {
            return _plainText;
        }
        else if (_hidden && !_hinted)
        {
            return _hiddenText;
        }
        else 
        {
            return _hintedText;
        }
        
    }

    public bool IsHidden()
    {
        return _hidden;
    }

    public void SetHidden()
    {
        _hidden = true;
    }

    public bool IsHinted()
    {
        return _hinted;
    }

    public void SetHinted()
    {
        _hinted = true;
    }

    
}