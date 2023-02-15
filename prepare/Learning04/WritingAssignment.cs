// Inheritance Learning Activity    Week 07
// Author : Nelson Mathurent
// Date:    Feb 14, 2023

public class WritingAssignment : Assignment
{
    private string _title;

    // Constructor that has four parameters, the student name, the topic, the textbook section and the problems.
    public WritingAssignment(string studentName, string topic, string title): base(studentName, topic)
    {
        _title = title;
    }

    // Returns the writing information
    public string GetWritingInformation()
    {
        return $"{_title} by {GetStudentName()}";
    }

}