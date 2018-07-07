using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace WordCounter.Models
{
    public class WordCounter
    {
        private string _wordToCount;
        private string _paragraphToScan;
        private string[] _arrayFromParagraph;
        private int _counter;

        /**
         * Class constructor
         */
        public WordCounter()
        {

        }
        public WordCounter(string searchFor, string searchIn)
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

        /**
         * This method takes in a string sentence/paragraph and splits it into a string array.
         */
        public string[] StringToArray()
        {
            this._arrayFromParagraph = this._paragraphToScan.Split(' ');
            return this._arrayFromParagraph;
        }

        /**
         * This method searches through a given string array and counts occurences of a specified string
         */
        public int GetResults()
        {
            int count = 0;
            for(int i=0; i < this._arrayFromParagraph.Length; i++)
            {
                if(this._arrayFromParagraph[i] == this._wordToCount)
                {
                    count += 1;
                }
                else
                {
                    count += 0;
                }
            }
            this._counter = count;
            return this._counter;
        }
    }

    /**
     * Main method
     * Searches for the number of times a word appears in a sentence or paragraph
     */
    public class Program
    {
        public static void Main()
        {
            WordCounter stringCheckObject = new WordCounter("cat", "cat cat cat");
            stringCheckObject.StringToArray();
            int count = stringCheckObject.GetResults();
            Console.WriteLine(count); //output: 3

            WordCounter stringCheckObject2 = new WordCounter("cat", "cat dog cat");
            stringCheckObject2.StringToArray();
            count = stringCheckObject2.GetResults();
            Console.WriteLine(count); //output: 2

            WordCounter stringCheckObject3 = new WordCounter();
            string wordy = "cow";
            stringCheckObject3.SetWordToCount(wordy);
            string sentence = "The cow is big, the cow taste great";
            stringCheckObject3.SetParagraph(sentence);
            stringCheckObject3.StringToArray();
            count = stringCheckObject3.GetResults();
            Console.WriteLine(count); //output: 2
        }
    }
}
