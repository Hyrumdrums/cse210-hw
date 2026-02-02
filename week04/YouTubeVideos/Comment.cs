public class Comment
{
  private DateTime _dateCreated;
  private string _author;
  private string _text;

  public Comment(string author, string text)
  {

    _dateCreated = DateTime.Now;
    _author = author;
    _text = text;
  }

  public string GetCommentContent()
  {
    // short format date
    string formattedDate = _dateCreated.ToString("g");
    return $"{formattedDate} {_author}: {_text}";
  }
  
}