using System;
public class Entry 
{
    public string or_date;
    public string or_promptText;
    public string or_entryText;

    public void Display() 
    {
        Console.WriteLine($"Date: {or_date} - Prompt : {or_promptText}");
        Console.WriteLine($"{or_entryText}");
    }
}