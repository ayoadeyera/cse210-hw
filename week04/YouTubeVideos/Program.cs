using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store our videos
        List<Video> videos = new List<Video>();

        // Create Video 1 and add comments
        Video video1 = new Video("C# Basics", "Code Academy", 600);
        video1._comments.Add(new Comment("John", "Great tutorial!"));
        video1._comments.Add(new Comment("Sarah", "Very helpful, thanks."));
        video1._comments.Add(new Comment("Mike", "Could you explain loops more?"));
        videos.Add(video1);

        // Create Video 2 and add comments
        Video video2 = new Video("Abstraction Explained", "Tech Tips", 450);
        video2._comments.Add(new Comment("Alice", "I finally understand classes."));
        video2._comments.Add(new Comment("Bob", "Best explanation so far."));
        video2._comments.Add(new Comment("Charlie", "Short and sweet."));
        videos.Add(video2);

        // Create Video 3 and add comments
        Video video3 = new Video("Cooking 101", "Chef Maria", 1200);
        video3._comments.Add(new Comment("Dave", "That steak looks amazing."));
        video3._comments.Add(new Comment("Eve", "Tried this at home, loved it!"));
        video3._comments.Add(new Comment("Frank", "What kind of pan is that?"));
        videos.Add(video3);

        // Iterate and Display
        foreach (Video video in videos)
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($"- {comment._name}: {comment._text}");
            }
            Console.WriteLine();
        }
    }
}