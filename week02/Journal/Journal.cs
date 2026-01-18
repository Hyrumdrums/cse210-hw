public class Journal
{
  private List<Entry> _entryList = new List<Entry>();
  public void AddEntry(Entry entry) {
    _entryList.Add(entry);
  }
  public void AddEntry(string prompt, string response) {
    Entry entry = new Entry();
    entry._date = DateTime.Now.ToString("yyyy-MM-dd");
    entry._promptText = prompt;
    entry._entryText = response;
    _entryList.Add(entry);
  }
  public void DisplayAllEntries() {
    foreach (Entry entry in _entryList) {
      entry.Display();
    }
  }
  public void SaveToFile(string filename) {
    using (StreamWriter writer = new StreamWriter(filename)) {
      foreach (Entry entry in _entryList) {
        writer.WriteLine(entry.AsString());
      }
    }
  }
  public void LoadFromFile(string filename)
  {
    _entryList.Clear();
    using (StreamReader reader = new StreamReader(filename)) {
      string line;
      while ((line = reader.ReadLine()) != null) {
        Entry entry = Entry.FromString(line);
        _entryList.Add(entry);
      }
    }
  }
}
