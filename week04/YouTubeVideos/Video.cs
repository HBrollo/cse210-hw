using System.Diagnostics.Contracts;
using System;

public class Video
{
    public string title;
    public string author;
    public int length;
    private List<Comment> commentList = new List<Comment>();

    public void addComment(Comment newComment)
    {
        commentList.Add(newComment);
    }

    public void displayVideoStats()
    {
        Console.WriteLine($"Video Title: {title}");
        Console.WriteLine($"Video Author: {author}");
        Console.WriteLine($"Video Length: {length} seconds, or {length/60} minutes");
    }
    public void displayComments()
    {
        Console.WriteLine($"There are {commentList.Count} comments");
        foreach (Comment commentItem in commentList)
        {
            Console.WriteLine($"Author: {commentItem.authorName}");
            Console.WriteLine($"Comment: {commentItem.comment}");
        }
    }

}