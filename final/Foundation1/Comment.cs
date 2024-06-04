

public class Comment
{
    private string _commentatorName;
    private string _theComment;

    public Comment(string name, string comment)
    {
        _commentatorName = name;
        _theComment = comment;
    }
    
    public string GetCommentatorName()
    {
        return _commentatorName;
    }
    public string GetTheComment()
    {
        return _theComment;
    }
}