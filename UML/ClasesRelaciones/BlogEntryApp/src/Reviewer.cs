namespace BlogEntryReviewRel;

public class Reviewer
{
    private readonly List<BlogEntry> _blogEntries = new List<BlogEntry>();
    private int _reviewerId;

    // la multiplicidad es?

    public Reviewer(string reviwerName)
    {
        this.ReviewerName = reviwerName;
    }

    public int ReviewerId
    {
        set { _reviewerId = value; }
        get { return _reviewerId; }
    }
    public string ReviewerName { get; set; }

    public void AddBlogEntry(BlogEntry blogEntry)
    {
        _blogEntries.Add(blogEntry);
    }

    public List<BlogEntry> BlogsToReview()
    {
        return _blogEntries;
    }
}