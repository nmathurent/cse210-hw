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
        Console.WriteLine(_title);
    }

    public int CalculateNumberOfComments() {
        return 0;
    }

}

