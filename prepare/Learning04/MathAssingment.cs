using System;

class MathAssingment : Assignment
{
    private string _textBookSection = "";
    private string _problems = "";

    public MathAssingment (string textBookSection, string problems, string studentName, string topic) : base (studentName, topic)
    {
        _textBookSection = textBookSection;
        _problems = problems;
    }

    public string GetHomeWork(){
        return $"Section {_textBookSection} Problems {_problems}";
    }
}