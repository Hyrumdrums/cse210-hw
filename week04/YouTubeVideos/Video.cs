using System.Transactions;

public class Video
{
  private string _title;
  private string _author;
  private int _length;
  private List<Comment> _comments;

  public Video(string title, string author, int length)
  {
    _title = title;
    _author = author;
    _length = length;
    _comments = new List<Comment>();
  }

  public void AddComment(string Author, string Text)
  {
    Comment comment = new Comment(Author, Text);
    _comments.Add(comment);
  }

  public int CountComments()
  {
    return _comments.Count;
  }

  public string GetDisplayText()
  {
    return $"{_title} by {_author}, Length: {_length} seconds, Comments: {CountComments()}";
  }

  public string GetCommentsContent()
  {
    string allComments = "";
    foreach (Comment comment in _comments)
    {
      allComments += comment.GetCommentContent() + "\n";
    }
    return allComments;
  }


}