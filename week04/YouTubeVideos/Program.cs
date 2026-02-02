using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>();
        
        Video video1 = new Video("Making Pizza", "Dallin Layton", 600);
        video1.AddComment("Alice", "Great video! I loved the pizza recipe.");
        video1.AddComment("Ben", "Thanks for sharing, very helpful.");
        video1.AddComment("Devin", "Can't wait to try this at home.");
        videoList.Add(video1);

        Video video2 = new Video("How To Put Out a Kitchen Fire", "Dallin Layton", 1200);
        video2.AddComment("Eve", "Very informative, thanks!");
        video2.AddComment("Bill", "I learned a lot from this video.");
        video2.AddComment("Buggy", "This could save lives, great job!");
        videoList.Add(video2);

        Video video3 = new Video("How To Remodel Your Kitchen", "Dallin Layton", 1000);
        video3.AddComment("Grace", "Great tips for kitchen remodeling.");
        video3.AddComment("Hank", "I'm planning a kitchen remodel, this is very helpful.");
        video3.AddComment("Ivy", "Loved the design ideas, thanks for sharing!");
        videoList.Add(video3);

        foreach (Video video in videoList)
        {
            Console.WriteLine(video.GetDisplayText());
            Console.WriteLine("Comments:");
            Console.WriteLine(video.GetCommentsContent());
            Console.WriteLine();
        }
    }
}