using System;

class Program
{
    static void Main(string[] args)
    
    {
        
        Prompt gen = new Prompt();
        gen.or_prompts.Add("What are three things you're grateful for today?");
        gen.or_prompts.Add("Write about a person who positively impacted your day.");
        gen.or_prompts.Add("What accomplishments are you proud of today?");
        gen.or_prompts.Add("Did you perform or witness an act of kindness today? Describe it.");
        gen.or_prompts.Add("If I had one thing I could do over today, what would it be?");

        Journal or_daily = new Journal();

        string choice = "";

        do 
        {
            Console.WriteLine("Please select one of the following choices: ");
            List<string> options = new List<string> {"1.Write", "2.Display", "3.Load", "4.Save", "5.Quit"};
            foreach (string option in options) 
            {
                Console.WriteLine(option);
            }
                Console.Write(">");
                choice = Console.ReadLine();

            if (choice == "1") 
            {

                DateTime current = DateTime.Now;
                Entry ent1 = new Entry();
                ent1.or_promptText = gen.GetRandomPrompt();
                ent1.or_date = current.ToShortDateString();


                Console.Write(ent1.or_promptText);
                ent1.or_entryText = Console.ReadLine();               
                or_daily.or_entries.Add(ent1);

            } 
            else if (choice == "2")
            {
                or_daily.DisplayAll();
            }

            else if (choice == "3")
            {
                Console.WriteLine("What is the filename?");
                string name = Console.ReadLine();

                or_daily.or_entries = or_daily.LoadFromFile(name);         
                
                
            } else if (choice == "4")
            
            {
                or_daily.SaveToFile(or_daily.or_entries);   
            }

                        
        } while (choice != "5");
        
    
    }
}
