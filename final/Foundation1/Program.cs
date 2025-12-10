using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        int number = 0;

        Video video1 = new Video("Fail Compilation#1", "stinkycheeze", "15 minutes");
        video1.AppendComment(new Comment("Rick123", "'Great video, man!'"));
        video1.AppendComment(new Comment("JimmyJon", "'The first guy was too cool'"));
        video1.AppendComment(new Comment("dagonz", "'Can't believe the first guy lived'"));

        Video video2 = new Video("How to carve a pumpkin", "spookyyt", "30 minutes");
        video2.AppendComment(new Comment("mcgamer", "'Cool pumpkins, where did you get em?'"));
        video2.AppendComment(new Comment("Ilovecats", "'I wish Halloween was every day'"));
        video2.AppendComment(new Comment("bandriving", "'never carved a pumpkin before so this was helpful'"));

        Video video3 = new Video("Gaining 100k subcribers in a day", "downundergaming", "20 minutes");
        video3.AppendComment(new Comment("Shiloh", "'Are you Australian?'"));
        video3.AppendComment(new Comment("rainyday", "'you should play more COD'"));
        video3.AppendComment(new Comment("humpackhenchman", "'I wish I had subscibers'"));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        
        foreach (Video video in videos)
        {
            Console.WriteLine($"Video #{number += 1}");
            Console.WriteLine("--------");
            video.Display();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}