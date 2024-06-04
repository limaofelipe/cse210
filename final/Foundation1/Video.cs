

public class Video
{
    private string _author;
    private string _title;
    private int _videoLength;
    private List<Comment> _comments = new();

    // *args kwarg*
    public void SetVideoMeta(params object[] args)
    {
        _author = args[0].ToString();
        _title = args[1].ToString();
        _videoLength = int.Parse(args[2].ToString());
    }

    public string GetAuthor()
    {
        return _author;
    }

    public string GetTitle()
    {
        return _title;
    }

    public int GetVideoLength()
    {
        return _videoLength;
    }

    public void SetComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void DisplayComment()
    {
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"{comment.GetCommentatorName()} - {comment.GetTheComment()}");
        }
        Console.WriteLine("");
    }

    public void DisplayMetaData()
    {
        string meta = $"Author of Video: {GetAuthor()}\nTitle: {GetTitle()}\nVideo length: {GetVideoLength()}min(s)";
        Console.WriteLine(meta);
    }
}