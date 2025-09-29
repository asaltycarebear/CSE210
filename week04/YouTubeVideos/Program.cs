using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Video Title A", "Name A", 200);
        video1.AddComment(new Comment("Humman 1", "Such Video"));
        video1.AddComment(new Comment("The Robot Gary", "Very Wit."));

        Video video2 = new Video("Video Title B", "Name B", 400);
        video2.AddComment(new Comment("DefinatlyNotABot", "Such Clip"));
        video2.AddComment(new Comment("The Robot Gary", "Very Content."));

        List<Video> videos = new List<Video> { video1, video2 };

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLengthInSeconds()} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"\t{comment.GetName()}: {comment.GetText()}");
            }
        }
    }
}
