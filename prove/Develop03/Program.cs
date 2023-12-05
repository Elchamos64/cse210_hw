using System;
using System.Diagnostics.CodeAnalysis;

class Program {
    static void Main(string[] args) {
        Console.Clear();

        Reference reference = new Reference();
        string or_text = reference.getText();
        string or_reference = reference.getReference(); 

        
        Scripture scripture = new Scripture(or_text, or_reference);

        
        while (!scripture.AreAllWordsHidden()) {
            Console.Clear();
            Console.WriteLine(scripture.ToString());
            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine(); 

            if (input == "quit") {
                break;
            }

            scripture.HideRandomWord();
        }

    }
}