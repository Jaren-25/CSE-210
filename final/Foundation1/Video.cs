public class Video
{
    private string _title;
    private string _author;
    private double _length;
    private List<Comment> _comments = new();
    private List<Video> _videos = new();


    public Video()
    {

    }

    public Video(string title, string author, double length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddVideo(Video video)
    {
        _videos.AddRange(video);
    }

    public void AddComment(Comment comment)
    {
        _comments.AddRange(comment);
    }

    public List<Video> GetVideos()
    {
        return _videos;
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }

    public string DisplayVideo()
    {
        return $"Title: {_title} ({_author}), {_length} seconds";
    }
}