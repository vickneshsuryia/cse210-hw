class Reference
{
    //attributes
    private string _book;
    private int _chapter;
    private int _verse;
    private int _verseStart;
    private int _verseEnd;
    //behaviors
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    public Reference(string book, int chapter, int verseStart, int verseEnd)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _verseEnd = verseEnd;
    }
    public string GetReference()
    {
        if (_verseEnd > 0)
            return $"{_book} {_chapter}:{_verseStart}-{_verseEnd}";
        
        else
            return $"{_book} {_chapter}:{_verse}";
    }
}