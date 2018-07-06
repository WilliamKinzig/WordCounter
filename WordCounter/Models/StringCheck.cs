using System;

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

        public string CountInstances(string sentence)
        {
            // var foos = "Foo1,Foo2,Foo3";
            // var fooArray = foos.Split(',');  // now you have an array of 3 strings
            // foos = String.Join(",", fooArray); // now you have the same as in the first line
            string[] words = sentence.Split(' ');
            string arrayIndex = words[0];
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
