class Scripture
{
    //attributes
    private string _scripture;
    private List<Word> _words = new List<Word>();
    private Reference _reference;
    //behaviors
    public Scripture(Reference reference, string scripture)
    {
        _reference = reference;
        _scripture = scripture;
        foreach (string word in scripture.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }
    public void Display()
    {
        Console.Write(_reference.GetReference() + " ");
        foreach (Word w in _words)
        {
            Console.Write(w.GetDisplayWord() + " ");
        }
        Console.WriteLine();   
    }
    public void HideWords()
    {
        Random rand = new Random();
        for (int i = 0; i < 3; i++)
        {
            int index = rand.Next(_words.Count);
            _words[index].Hide();
        }
    }
    public bool IsHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}