// Abstraction with YouTube Videos Program    Week 12
// Author : Nelson Mathurent
// Date:    Mar 20, 2023

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _commentList;

    public string GetTitle() {
        return _title;
    }
    public void SetTitle(string title) {
        _title = title;
    }

    public void DisplayVideo() {
        Console.WriteLine(GetTitle());
    }

    public int CalculateNumberOfComments() {
        return 0;
    }

}

