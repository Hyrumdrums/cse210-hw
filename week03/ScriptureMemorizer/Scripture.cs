public class Scripture
{
  private Reference _reference;
  private List<Word> _wordList;

  public Scripture(Reference reference, string text)
  {
    _reference = reference;
    _wordList = new List<Word>();
    text = text.Trim();
    string[] splitWords = text.Split(' ');
    foreach (string word in splitWords)
    {
      _wordList.Add(new Word(word));
    }
  }

  public void HideRandomWords(int count)
  {
    // enforce max
    count = Math.Min(count, _wordList.Count);
    Random random = new Random();
    int hiddenCount = 0;
    // prevent infinite loop looking for unhidden words when all are hidden
    int unhiddenWordCount = CountUnhiddenWords();
    count = Math.Min(count, unhiddenWordCount);
    // could improve efficiency
    while (hiddenCount < count)
    {
      int index = random.Next(_wordList.Count);
      Word word = _wordList[index];
      if (!word.IsHidden())
      {
        word.Hide();
        hiddenCount++;
      }
    }
  }

  public int CountUnhiddenWords()
  {
    int count = 0;
    foreach (Word word in _wordList)
    {
      if (!word.IsHidden())
      {
        count++;
      }
    }
    return count;
  }

  public string GetDisplayText()
  {
    List<string> displayWords = new List<string>();
    foreach (Word word in _wordList)
    {
      displayWords.Add(word.GetDisplayText());
    }
    string scripture = string.Join(" ", displayWords);

    string reference = _reference.GetDisplayText();
    return $"{reference} {scripture}";
  }
}