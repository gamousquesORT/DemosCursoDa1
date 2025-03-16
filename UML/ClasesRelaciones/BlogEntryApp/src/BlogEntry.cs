namespace BlogEntryReviewRel;

public class BlogEntry
{
    private static long _numberOfPosts;
    private readonly long _postId;

    public BlogEntry()
    {
        Post = "a";
        _postId = _numberOfPosts++;
    }

    public string Post { get; set; } = "a";


    public override string ToString()
    {
        return Post;
    }

    public bool Equals(BlogEntry? other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return _postId == other._postId;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != GetType()) return false;
        return Equals((BlogEntry) obj);
    }

    public override int GetHashCode()
    {
        return _postId.GetHashCode();
    }

    public static bool operator ==(BlogEntry? left, BlogEntry? right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(BlogEntry? left, BlogEntry? right)
    {
        return !Equals(left, right);
    }
}