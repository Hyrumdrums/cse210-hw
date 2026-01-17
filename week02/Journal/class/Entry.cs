using System.ComponentModel.DataAnnotations;
using System.IO.Compression;

public class Entry
{
  public string _date;
  public string _promptText;
  public string _entryText;
  public void Display()
  {
    Console.WriteLine($"{_date} - {_promptText}\n{_entryText}\n");
  }
  public static Entry FromString(string line)
  {
    string[] parts = line.Split('|');
    Entry entry = new Entry();
    entry._date = parts[0];
    entry._promptText = parts[1];
    entry._entryText = parts[2];
    return entry;
  }
  public string AsString()
  {
    return $"{_date}|{_promptText}|{_entryText}";
  }
}