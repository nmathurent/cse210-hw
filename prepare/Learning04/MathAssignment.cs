// Inheritance Learning Activity    Week 07
// Author : Nelson Mathurent
// Date:    Feb 14, 2023

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    // Constructor that has four parameters, the student name, the topic, the textbook section and the problems.
    public MathAssignment(string studentName, string topic, string textbookSection, string problems): base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    // Returns the homework list
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }

}