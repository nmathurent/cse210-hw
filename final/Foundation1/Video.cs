// Abstraction with YouTube Videos Program    Week 12
// Author : Nelson Mathurent
// Date:    Mar 20, 2023

public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _commentList = new List<Comment>();

    public Video(string title, string author, int length, List<Comment> commentList)
    {
        _title = title;
        _author = author;
        _length = length;
        _commentList = commentList;
    }

    public void DisplayVideo() {
        Console.WriteLine($"\nTitle: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Duration: {_length} seconds");
        Console.WriteLine("\nComments:");
        foreach (Comment comment in _commentList)
        {
            comment.DisplayComment();
        }
        Console.WriteLine($"Number of Comments:{CalculateNumberOfComments()}");
    }

    public int CalculateNumberOfComments() {
        int numComments = 0;
        foreach (Comment comment in _commentList)
        {
            numComments += 1;
        }
        return numComments;
    }

}

