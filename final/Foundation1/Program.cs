class Program
{
    static void Main(string[] args)
    {

        List<Video> videos = new();


        // Video video = new Video();
        List<Comment> comments1 = new List<Comment>();
        Video v1 = new("t1", "a1", 1.1, comments1);
        comments1.AddRange(new Comment("ca1", "text1"));
        comments1.AddRange(new Comment("ca2", "text2"));
        comments1.AddRange(new Comment("ca3", "text3"));
        comments1.AddRange(new Comment("ca4", "text4"));



        List<Comment> comments2 = new List<Comment>();
        Video v2 = new("t2", "a2", 2.1, comments2);
        comments2.AddRange(new Comment("ca5", "text5"));
        comments2.AddRange(new Comment("ca6", "text6"));
        comments2.AddRange(new Comment("ca7", "text7"));
        comments2.AddRange(new Comment("ca8", "text8"));

        List<Comment> comments3 = new List<Comment>();
        Video v3 = new("t3", "a3", 3.1, comments3);
        comments3.AddRange(new Comment("ca9", "text9"));
        comments3.AddRange(new Comment("ca10", "text10"));
        comments3.AddRange(new Comment("ca11", "text11"));
        comments3.AddRange(new Comment("ca12", "text12"));

        List<Comment> comments4 = new List<Comment>();
        Video v4 = new("t4", "a4", 4.1, comments4);
        comments4.AddRange(new Comment("ca13", "text13"));
        comments4.AddRange(new Comment("ca14", "text14"));
        comments4.AddRange(new Comment("ca15", "text15"));
        comments4.AddRange(new Comment("ca16", "text16"));

        videos.Add(v1);
        videos.Add(v2);
        videos.Add(v3);
        videos.Add(v4);

        foreach(Video vid in videos)
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