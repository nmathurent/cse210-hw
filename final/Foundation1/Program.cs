using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>();
        List<Comment> commentList = new List<Comment>();
        List<Comment> commentList2 = new List<Comment>();
        List<Comment> commentList3 = new List<Comment>();

        Console.Clear();
        Console.WriteLine("Welcome to YouTube Video program!");
        Comment comment1 = new Comment("John", "I really like your video");
        commentList.Add(comment1);
        Comment comment2 = new Comment("Mary", "Great video!!");
        commentList.Add(comment2);
        Comment comment3 = new Comment("Randy", "Please add more similar videos!!");
        commentList.Add(comment3);
        Video video1 = new Video("First 1st Video", "Peter Smith", 35, commentList);
        video1._commentList = commentList;
        videoList.Add(video1);

        Comment comment4 = new Comment("Brandon", "I did not like your video, too short");
        commentList2.Add(comment4);
        Comment comment5 = new Comment("Clark", "Awesome video!!");
        commentList2.Add(comment5);
        Video video2 = new Video("Second Video", "Bryan Beaver", 45, commentList2);
        videoList.Add(video2);

        Comment comment6 = new Comment("Juan", "More videos like this please");
        commentList3.Add(comment6);
        Comment comment7 = new Comment("Julie", "Beautiful video!!");
        commentList3.Add(comment7);
        Comment comment8 = new Comment("Christine", "Keep posting!!");
        commentList3.Add(comment8);
        Comment comment9 = new Comment("Lewis", "Fantastic!!");
        commentList3.Add(comment9);
        Video video3 = new Video("Third 1st Video", "Brad Allen", 60, commentList3);
        video1._commentList = commentList3;
        videoList.Add(video3);

        foreach (Video video in videoList)
        {
            video.DisplayVideo();
        }
        

    }
        
}