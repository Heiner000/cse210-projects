using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");
        Console.WriteLine("Let's take a look at some YouTube data!");

        List<Video> videos = new List<Video>();

        Video vid1 = new Video("Karate Kats", "Memezar", 300);
        vid1.AddComment(new Comment("@Memelord", "I love cats that know karate!"));
        vid1.AddComment(new Comment("@grannyFurb", "these cats look just like my cats"));
        vid1.AddComment(new Comment("@Kimmy92", "How do I get my cats on here?"));
        vid1.AddComment(new Comment("@JelicalCat", "jelical jelical jelical hiyah!"));
        videos.Add(vid1);

        Video vid2 = new Video("Fortnite Highlights", "yung-gamer", 600);
        vid2.AddComment(new Comment("@drack00", "I would have dominated this!"));
        vid2.AddComment(new Comment("@oldbox", "Did you see that sweep - textbook!"));
        vid2.AddComment(new Comment("@Daniel-b", "This game looks fun."));
        vid2.AddComment(new Comment("@maieen245", "This game is terrible..."));
        videos.Add(vid2);

        Video vid3 = new Video("How to Make YouTube Videos", "Mr. Beast", 3600);
        vid3.AddComment(new Comment("@georgie-boyz", "Excellent content!!"));
        vid3.AddComment(new Comment("@hanetz", "Very good to know."));
        vid3.AddComment(new Comment("@i4n", "I love you Mr. Beast"));
        videos.Add(vid3);
        
        foreach (Video video in videos)
        {
            video.DisplayVideoDetails();
            Console.WriteLine();
        }
    }
}