using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>();
        List<Comment> commentList = new List<Comment>();
        List<Comment> commentList2 = new List<Comment>();
        Console.Clear();
        Console.WriteLine("Welcome to YouTube Video program!");
        Video video1 = new Video();
        video1._title = "First Video";
        video1._author = "Peter Smith";
        video1._length = 35;
        Comment comment1 = new Comment();
        comment1._writtenBy = "John";
        comment1._commentText = "I really like your video";
        commentList.Add(comment1);
        Comment comment2 = new Comment();
        comment2._writtenBy = "Mary";
        comment2._commentText = "Great video!!";
        commentList.Add(comment2);
        video1._commentList = commentList;
        videoList.Add(video1);

        Video video2 = new Video();
        video2._title = "Second Video";
        video2._author = "Bryan Beaver";
        video2._length = 45;
        Comment comment3 = new Comment();
        comment3._writtenBy = "Brandon";
        comment3._commentText = "I did not like your video, too long";
        commentList2.Add(comment3);
        Comment comment4 = new Comment();
        comment4._writtenBy = "Clark";
        comment4._commentText = "Awesome video!!";
        commentList2.Add(comment4);
        video2._commentList = commentList2;
        videoList.Add(video2);

        foreach (Video video in videoList)
        {
            video.DisplayVideo();
        }
        

    }
        
}