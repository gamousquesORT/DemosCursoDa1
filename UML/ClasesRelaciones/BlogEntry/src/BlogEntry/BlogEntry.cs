namespace BlogEntry;

public class BlogEntry
{
    private long _id = 0;
    private string _post;
    private static long _numberOfPost;

    static BlogEntry()
    {
        _numberOfPost = 0;
    }

    public BlogEntry()
    {
        _id = _numberOfPost++;
        _post = "invalid text";
    }

    public BlogEntry(string post)
    {
        _post = post;
    }
    public long Id { get => _id; }
    public string Post
    {
        get => _post;
        set
        {
            if (value == "") throw new ArgumentException("Post cannot be empty");
            _post = value;
        }
    }
}