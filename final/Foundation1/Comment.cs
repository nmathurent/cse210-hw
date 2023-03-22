// Abstraction with YouTube Videos Program    Week 12
// Author : Nelson Mathurent
// Date:    Mar 20, 2023

public class Comment
{
    public string _writtenBy;
    public string _commentText;

    public Comment(string writtenBy, string commentText)
    {
        _writtenBy = writtenBy;
        _commentText = commentText;
    }

    public void DisplayComment() {
        Console.WriteLine($"    {_writtenBy}: {_commentText}");
    }

}

