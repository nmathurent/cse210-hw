using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>();
        List<Comment> commentList = new List<Comment>();
        Console.Clear();
        Console.WriteLine("Welcome to YouTube Video program!");
        Video video1 = new Video();
        video1._title = "First Video";
        video1._author = "Peter Smith";
        video1._length = 35;
        Comment comment1 = new Comment();
        comment1.
        videoList.Add(video1);
        Video video2 = new Video();
        video2._title = "Second Video";
        videoList.Add(video2);

        foreach (Video video in videoList)
        {
            video.DisplayVideo();
        }
        

    }
        
}