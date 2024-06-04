using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!\n");
        List<Video> videos = new();

        void DisplayVideoData()
        {
            int count = 0;
            foreach (Video video in videos)
            {
                count++;
                Console.WriteLine($"Video0{count} - 4k");
                video.DisplayMetaData();
                Console.WriteLine("\nComments:");
                video.DisplayComment();
            }
        }

        // Instantiating the Video objects
        Video video1 = new();
        Video video2 = new();
        Video video3 = new();
        // Instantiating the Comment class
        Comment comment = new("Sarah", "Amazing tips and tricks");

        // Video1
        video1.SetVideoMeta("Peter Mckinnon", "Making Epic B-Rolls", 10);
        video1.SetComment(comment);
        ///////////////////////////
        comment = new("Jerry", "Love it ❤️");
        video1.SetComment(comment);
        ///////////////////////////
        comment = new("Abigial", "Peter never disappoints");
        video1.SetComment(comment);
        ////////////////////////////
        videos.Add(video1);

        // Video2
        video2.SetVideoMeta("Enes Yilmazer", "$20,000,000 Beverly Hill Mansion", 30);
        comment = new("Koigor", "Modern Luxury leaving");
        video2.SetComment(comment);
        ///////////////////////////
        comment = new("Josephine", "What a home");
        video2.SetComment(comment);
        ///////////////////////////
        comment = new("Naldo", "That's too much house for me 😃");
        video2.SetComment(comment);
        ////////////////////////////
        videos.Add(video2);

        // Video3
        video3.SetVideoMeta("Chris Sean", "Day in the life of Software Engineer", 10);
        comment = new("Mion", "More of these videos 👍🏽");
        video3.SetComment(comment);
        ///////////////////////////
        comment = new("MacMillan", "Is it all coffee and great views?");
        video3.SetComment(comment);
        ///////////////////////////
        comment = new("Fogbawa", "Love the video Chris 🫡");
        video3.SetComment(comment);
        ////////////////////////////
        videos.Add(video3);
        DisplayVideoData();

    }
}