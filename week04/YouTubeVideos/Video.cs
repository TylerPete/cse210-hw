using System.ComponentModel.DataAnnotations;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public string GetDisplayText()
    {
        return $"{_title} by {_author}; Length: {_length} seconds";
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public string GetAllCommentsDisplayText()
    {
        string allComments = "";

        foreach (Comment comment in _comments)
        {
            allComments += $"{comment.GetDisplayText()}\r\n";
        }

        return allComments;
    }        
    public Video(string title, string author, int length, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = comments;
    }
}