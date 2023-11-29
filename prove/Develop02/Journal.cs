using System;
public class Journal 
{
    public List<Entry>  or_entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        or_entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry promp in or_entries) 
        {
            promp.Display();
        }
    }

    public void SaveToFile(List<Entry> or_entries) 
    
    {
        Console.WriteLine("What is the filename? ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename)) 
        {
           foreach (Entry p in or_entries) 
           {

                outputFile.WriteLine($"{p.or_date},{p.or_promptText},{p.or_entryText}");
           }
           
          
        }
    }

    public List<Entry> LoadFromFile(string file)
    {
       string[] lines = System.IO.File.ReadAllLines(file);
       List<Entry> newData = new List<Entry>();

       foreach (string line in lines)
       {
            string[] parts = line.Split(",");

            Entry data = new Entry();
            data.or_date = parts[0];
            data.or_promptText = parts[1];
            data.or_entryText = parts[2];

           
            newData.Add(data); 
       }

       return newData;
    }
}