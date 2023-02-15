// Inheritance Learning Activity    Week 07
// Author : Nelson Mathurent
// Date:    Feb 14, 2023

public class Assignment
{
    private string _studentName;
    private string _topic;

    public string GetStudentName() {
        return _studentName;
    }
    
    // Constructor that has two parameters, one for the student name and one for the topic.
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Returns the student's name and the topic
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

}