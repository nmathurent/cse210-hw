// Encapsulation Learning Activity    Week 05
// Author : Nelson Mathurent
// Date:    Jan 30, 2023

public class Assignment
{
    private string _studentName;
    private string _topic;

    // Constructor that has two parameters, one for the student name and one for the topic.
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Returns the fraction in the form 3/4
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

}