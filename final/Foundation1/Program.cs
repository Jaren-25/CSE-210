class Program
{
    static void Main(string[] args)
    {
        Video video = new Video();

        Video v1 = new("t1", "a1", 1.1);
        v1.AddComment(new Comment("ca1", "text1"));
        v1.AddComment(new Comment("ca2", "text2"));
        v1.AddComment(new Comment("ca3", "text3"));
        v1.AddComment(new Comment("ca4", "text4"));

        Video v2 = new("t2", "a2", 2.1);
        v2.AddComment(new Comment("ca5", "text5"));
        v2.AddComment(new Comment("ca6", "text6"));
        v2.AddComment(new Comment("ca7", "text7"));
        v2.AddComment(new Comment("ca8", "text8"));

        Video v3 = new("t3", "a3", 3.1);
        v3.AddComment(new Comment("ca9", "text9"));
        v3.AddComment(new Comment("ca10", "text10"));
        v3.AddComment(new Comment("ca11", "text11"));
        v3.AddComment(new Comment("ca12", "text12"));

        Video v4 = new("t4", "a4", 4.1);
        v4.AddComment(new Comment("ca13", "text13"));
        v4.AddComment(new Comment("ca14", "text14"));
        v4.AddComment(new Comment("ca15", "text15"));
        v4.AddComment(new Comment("ca16", "text16"));

        video.AddVideo(v1);
        video.AddVideo(v2);
        video.AddVideo(v3);
        video.AddVideo(v4);

        foreach(Video vid in video.GetVideos())
        {
            Console.WriteLine(vid.DisplayVideo());

            foreach(Comment comment in vid.GetComments())
            {
                Console.WriteLine(comment.Display());
            }
            Console.WriteLine($"{vid.GetComments().Count()} comments total\n");
        }
    }
}