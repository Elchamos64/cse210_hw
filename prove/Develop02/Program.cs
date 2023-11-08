

using System;

class Program
{
    static void Main(string[] args)
    {
                    List<string> questions = new List<string>
            {
                "If I had one thing I could do over today? What would it be?",
                "What was the best part of my day", 
            };

            Random random = new Random();
            int randomIndex = random.Next(0, questions.Count);
            string randomQuestion = questions[randomIndex];

            Console.WriteLine(randomQuestion);
            Console.Write("> ");
            string orAnswer = Console.ReadLine();

            // Create the path
            string filePath = "answer.txt";

            try
            {
                // Write the answer to the text file
                System.IO.File.WriteAllText(filePath, randomQuestion + ": " + orAnswer);
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }
    }
}