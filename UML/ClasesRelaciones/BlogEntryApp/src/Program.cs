// See https://aka.ms/new-console-template for more information

namespace BlogEntryReviewRel;

public class Program
{
    public static void Main(string[] args)
    {
        var reviewer = new Reviewer("Gastón");

        CreateBlogEntries(reviewer, out var blogEntry);

        PrintBlogInformation(reviewer);
    }

    private static void PrintBlogInformation(Reviewer reviewer)
    {
        Console.WriteLine($"Listar los blog entries para el Reviwer:{reviewer.ReviewerName}\n");
        foreach (var p in reviewer.BlogsToReview()) 
            Console.WriteLine("El post dice: " + p + "\n");
    }

    private static void CreateBlogEntries(Reviewer reviewer, out BlogEntry blogEntry)
    {
        Console.WriteLine($"\n Creando un nuevo blog entry para Reviewer: {reviewer.ReviewerName}");
        blogEntry = new BlogEntry();
        blogEntry.Post = "mi primer post";
        reviewer.AddBlogEntry(blogEntry);

        Console.WriteLine($"\n Creando un nuevo blog entry para Reviewer: {reviewer.ReviewerName}\n");
        blogEntry = new BlogEntry();
        blogEntry.Post = "mi segundo post";
        reviewer.AddBlogEntry(blogEntry);
    }
}