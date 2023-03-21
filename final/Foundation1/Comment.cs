// Abstraction with YouTube Videos Program    Week 12
// Author : Nelson Mathurent
// Date:    Mar 20, 2023

public class Comment
{
    private string _writtenBy;
    private string _commentText;

    public string GetWrittenBy() {
        return _writtenBy;
    }
    public void SetTitle(string writtenBy) {
        _writtenBy = writtenBy;
    }
    public string GetCommentText() {
        return _commentText;
    }
    public void SetCommentText(string commentText) {
        _commentText = commentText;
    }
    public void DisplayComment() {
        Console.WriteLine(_writtenBy);
    }

}

