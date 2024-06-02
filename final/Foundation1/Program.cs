using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoCollection = new List<Video>();

        Video video1 = new Video();
        video1._title = "Inception Analysis";
        video1._author = "Christopher Nolan";
        video1._length = 45;

        Comment comment1Video1 = new Comment();
        comment1Video1._name = "Leonardo DiCaprio";
        comment1Video1._text = "Mind-bending and thought-provoking!";

        Comment comment2Video1 = new Comment("Joseph Gordon-Levitt", "The dream sequences are fantastic!");
        Comment comment3Video1 = new Comment("Ellen Page", "The cinematography is stunning.");

        video1._comments.Add(comment1Video1);
        video1._comments.Add(comment2Video1);
        video1._comments.Add(comment3Video1);

        Video video2 = new Video("Nature Documentary", "David Attenborough", 60);
        Comment comment1Video2 = new Comment("Jane Goodall", "Incredible insights into wildlife!");
        Comment comment2Video2 = new Comment("Steve Irwin", "The shots of the jungle are amazing!");
        Comment comment3Video2 = new Comment("Dian Fossey", "Very informative and engaging.");

        video2._comments.Add(comment1Video2);
        video2._comments.Add(comment2Video2);
        video2._comments.Add(comment3Video2);

        Video video3 = new Video("Tech Innovations", "Elon Musk", 30);
        Comment comment1Video3 = new Comment("Bill Gates", "Very futuristic and innovative!");
        Comment comment2Video3 = new Comment("Mark Zuckerberg", "The possibilities are endless.");
        Comment comment3Video3 = new Comment("Sundar Pichai", "Exciting to see where technology is heading.");

        video3._comments.Add(comment1Video3);
        video3._comments.Add(comment2Video3);
        video3._comments.Add(comment3Video3);

        videoCollection.Add(video1);
        videoCollection.Add(video2);
        videoCollection.Add(video3); 

        foreach (Video video in videoCollection)
        {
            video.DisplayVideoDetails();
            video.DisplayComments();
        }  
    }
}