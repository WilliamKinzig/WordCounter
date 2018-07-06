using System;

namespace WordCounter.Models
{
    public class WordSearcher
    {
        private string _wordToCount;
        private string _paragraphToScan;
        private string[] _arrayFromParagraph;
        private int _counter = 0;

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

        public string[] StringToArray(string sentence)
        {
            string[] wordsArray = sentence.Split(' ');
            this._arrayFromParagraph = sentence.Split(' ');
            return wordsArray;
        }

        public int ArrayLoopCounter(string word, string[] arrayIn)
        {
            int count = 0;
            for(int i=0; i < arrayIn.Length; i++)
            {
                if(arrayIn[i] == word)
                {
                    count += 1;
                }
                else
                {
                    count += 0;
                }
            }
            this._counter = count;
            return count;
        }
    }

    public class Program
    {
        public static void Main()
        {

        }
    }
}
