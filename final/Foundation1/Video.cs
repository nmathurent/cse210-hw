// Abstraction with YouTube Videos Program    Week 12
// Author : Nelson Mathurent
// Date:    Mar 20, 2023

public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _commentList;

    public void DisplayVideo() {
        Console.WriteLine($"\n{_title}");
        Console.WriteLine(_author);
        Console.WriteLine($"Duration: {_length} seconds");
        Console.WriteLine("\nComments:");
        foreach (Comment comment in _commentList)
        {
            comment.DisplayComment();
        }
        Console.WriteLine($"\nNumber of Comments:{CalculateNumberOfComments()}");
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

