using System;
using System.Data;

// Create the Reference class
class Reference {
    private string or_reference; 
    private string or_text;


    public string getText(){
          Console.WriteLine("**************************************************************");
          Console.WriteLine("********* Welcome to the scripture reference program *********");
          Console.WriteLine("*  To start, please enter the scripture you want to memorize *");
          Console.WriteLine("**  After that, please enter the reference of the scripture **");
          Console.WriteLine("**************************************************************");
          Console.WriteLine("");
          Console.Write("Enter the text of the scripture you want to memorize: ");
          or_text = Console.ReadLine();
          return or_text;
   }


   public string getReference(){
        Console.Write("Write the reference of the scripture: ");
        or_reference = Console.ReadLine();
        return or_reference;
   }
}