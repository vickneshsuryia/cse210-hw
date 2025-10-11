public class Startmenu
{
    public List<string> _selection = new List<string> { "Write", "Display", "Load", "Save", "Quit" };
    public void Display()
    {
        foreach (string selection in _selection)
        {
            string firstletter = selection.Substring(0,1);
            Console.WriteLine($"{firstletter} - {selection}");
        }
    }
}