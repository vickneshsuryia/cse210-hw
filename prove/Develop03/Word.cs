class Word
{
    //attributes
    private string _word;
    private bool _isHidden;
    //behaviors
    public Word(string w)
    {
        _word = w;
        _isHidden = false;
    }
    public void Hide()
    {
        _isHidden = true;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayWord()
    {
        if (_isHidden)
        {
            return new string('_', _word.Length);
        }
        else
        {
            return _word;
        }
    }
}