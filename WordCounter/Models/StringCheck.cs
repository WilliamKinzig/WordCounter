using System;

namespace WordCounter.Models
{
    public class WordSearcher
    {
        private string _wordToCount;
        private string _paragraphToScan;
        private string[] _arrayFromParagraph;

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

        public string StringToArray(string sentence)
        {
            string[] words = sentence.Split(' ');
            string arrayIndex = words[2];
            _arrayFromParagraph = sentence.Split(' ');

            //To check array is working properly
            // string[] blah = sentence.Split(' ');
            // string bl = string.Join(" ", blah);
            // return bl;
            
            return arrayIndex;
        }



    }

    public class Program
    {
        public static void Main()
        {

        }
    }

}
