namespace BlogEntryTests;
using BlogEntry;

[TestClass]
public class BlogEntryTests
{
    [TestMethod]
    public void ShouldInitializeBlogIDToZero_WhenEmptyConstructorCalled()
    {

        BlogEntry blogEntry = new BlogEntry();
        long expected = 0;

        Assert.AreEqual(expected, blogEntry.Id);
    }
    
    [TestMethod]
    public void ShouldIncrementBlogID_AfterEachNewBlogEntryCreated()
    {
        BlogEntry firstBlogEntry = new BlogEntry();
        BlogEntry secondBlogEntry = new BlogEntry();
        long expected = 2;
        Assert.AreEqual(expected, secondBlogEntry.Id);
    }
    
    [TestMethod]
    public void ShouldInitialzePost_WhenParameterConstructorCalled()
    {
        BlogEntry blogEntry = new BlogEntry("First Blog Entry");
        string expected = "First Blog Entry";
        blogEntry.Post = expected;
        Assert.AreEqual(expected, blogEntry.Post);
    }

    [TestInitialize]
    public void ShouldReturnPost_WhenPostIsCalled()
    {
        BlogEntry blogEntry = new BlogEntry("First Blog Entry");
        string expected = "First Blog Entry";
        Assert.AreEqual(expected, blogEntry.Post);
    }
    
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void ShouldThrowArgumentException_WhenPostIsInvalid()
    {
        BlogEntry blogEntry = new BlogEntry();
        blogEntry.Post = "";
    }
}