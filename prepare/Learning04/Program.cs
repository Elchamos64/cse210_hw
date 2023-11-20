using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment student1 = new Assignment("Samuel Bennett","Multiplication");
        Console.WriteLine(student1.GetSummary());

        MathAssingment student2 = new MathAssingment("7.2", "8-9","Oscar Ramos", "Addition");
        Console.WriteLine(student2.GetSummary());
        Console.WriteLine(student2.GetHomeWork());

        WrittingAssignment student3 = new WrittingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(student3.GetSummary());
        Console.WriteLine(student3.GetWritingInformation());
    }
}