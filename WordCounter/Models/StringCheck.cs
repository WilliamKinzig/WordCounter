namespace WordCounter.Models
{
    public class WordSearcher
    {
        private string _wordToCount;
        private string _paragraphToScan;

        public WordSearcher (string searchFor, string searchIn)
        {
            _wordToCount = searchFor;
            _paragraphToScan = searchIn;
        }

        public string GetWordToCount()
        {
            return _wordToCount;
        }
        public void SetWordToCount(string newWord)
        {
            _wordToCount = newWord;
        }

        public void SetParagraph(string stringIn)
        {
            _paragraphToScan = stringIn;
        }
        public string GetParaGraph()
        {
            return _paragraphToScan;
        }





    }

    public class Program
    {
        public static void Main()
        {

        }
    }

}
