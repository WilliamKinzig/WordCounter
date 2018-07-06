using System;

namespace WordCounter.Models
{
    public class StringCheck
    {
        private string _wordToCount;
        private string _paragraphToScan;
        private string[] _arrayFromParagraph;
        private int _counter = 0;


        /**
         * Class constructor
         */
        public StringCheck(string searchFor, string searchIn)
        {
            _wordToCount = searchFor;
            _paragraphToScan = searchIn;
        }

        /**
         * Getters and Setters
         * set and get string to search for (word)
         * set and get string to search through (sentence/paragraph)
         */
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
         *
         * @param sting to split 'sentence'
         * @return wordsArray
         */
        public string[] StringToArray(string sentence)
        {
            string[] wordsArray = sentence.Split(' ');
            this._arrayFromParagraph = sentence.Split(' ');
            return wordsArray;
        }

        /**
         * This method searches through a given string array and counts occurences of a specified string
         *
         * @param word to search for 'word'
         * @param array to scan 'arrayIn'
         * @return count
         */
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
}

/************************************************************************************/
/************************************************************************************/
/**
 * Main method
 *
 * Searches for the number of times a word appears in a sentence or paragraph
 * @param
 * @return count
 */
 /************************************************************************************/
public class Program
{
    public static void Main()
    {
        int count = 0;

        StringCheck stringsObject = new StringCheck("cat", "cat cat cat");
        stringsObject.StringToArray
        stringsObject.ArrayLoopCounter

    }
}



// public string[] StringToArray(string sentence)
// {
//     string[] wordsArray = sentence.Split(' ');
//     this._arrayFromParagraph = sentence.Split(' ');
//     return wordsArray;
// }
//
// public int ArrayLoopCounter(string word, string[] arrayIn)
// {
//     int count = 0;
//     for(int i=0; i < arrayIn.Length; i++)
//     {
//         if(arrayIn[i] == word)
//         {
//             count += 1;
//         }
//         else
//         {
//             count += 0;
//         }
//     }
//     this._counter = count;
//     return count;
// }
