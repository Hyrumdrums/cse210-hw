public class PromptGenerator
{
  static List<string> _prompts = new List<string>()
  {
    "Who was the most interesting person I interacted with today?",
    "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?",
    "What challenged me the most today?",
    "What am I most grateful for right now?",
    "Did I learn something new today?",
    "Where did I succeed today, even in a small way?",
    "What moment today made me smile?",
    "Did I act in alignment with my values today?",
    "What could I do tomorrow to improve on today?",
    "Who did I help today, or who helped me?",
    "What drained my energy today?",
    "What gave me energy today?",
    "Did I take time to rest or care for myself today?",
    "What am I avoiding that I should address?",
    "What thought kept returning to my mind today?",
    "How did I show patience or kindness today?",
    "What am I looking forward to tomorrow?"
  };
  public static string GetRandomPrompt()
  {
    Random rand = new Random();
    int index = rand.Next(_prompts.Count);
    return _prompts[index];
  }
}