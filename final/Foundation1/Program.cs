using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>();
        Console.Clear();
        Console.WriteLine("Welcome to YouTube Video program!");
        Video video1 = new Video();
        video1.SetTitle("First Video");
        videoList.Add(video1);
        Video video2 = new Video();
        video2.SetTitle("Second Video");
        videoList.Add(video2);

        foreach (Video video in videoList)
        {
            video.DisplayVideo();
        }
        

    }
        
}