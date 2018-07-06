namespace WordCounter.Models
{
  public class WordSearcher
  {
    private string _description;
    public WordSearcher (string description)
    {
       _description = description; //uncomment to get test to pass
    }
    public string GetDescription()
    {
      return _description;
    }
    public void SetDescription(string newWord)
    {
      _description = newWord;
    }
  }
  public class Program
  {
    public static void Main()
    {

    }
  }

}
