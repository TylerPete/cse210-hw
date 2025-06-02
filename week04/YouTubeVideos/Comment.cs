public class Comment
{
    private string _username;
    private string _commentText;

    public string GetDisplayText()
    {
        return $"{_username}: {_commentText}";
    }

    public Comment(string username, string commentText)
    {
        _username = username;
        _commentText = commentText;
    }
}