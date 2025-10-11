public class Entry
{
    public string Prompt;
    public string Response;
    public string Date;

    public void Display()
    {
        Console.WriteLine($"{Date} - {Prompt}");
        Console.WriteLine($"Response: {Response}\n");
    }
}