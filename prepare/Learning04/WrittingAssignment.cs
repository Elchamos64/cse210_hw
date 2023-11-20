using System;

class WrittingAssignment : Assignment
{
    private string _title = "";

    public WrittingAssignment(string studentName, string topic, string title) : base (studentName, topic)
    {
        _title = title; 
    }

    public string GetWritingInformation ()
    {
        string _studentName = GetStudentName();
        return $"{_title} by {_studentName}";
    }
}