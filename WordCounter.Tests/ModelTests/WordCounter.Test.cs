using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class WordCounterTest
    {
        [TestMethod]
        public void GetStringToCount_ReturnStringsWorkingWith_String()
        {
            //Arrange
            WordCounter newWordCounter = new WordCounter("the","the yellow bus");

            //Act
            string toCount = newWordCounter.GetWordToCount();
            string toScan = newWordCounter.GetParaGraph();

            //Assert
            Assert.AreEqual(toScan, "the yellow bus");
        }

        [TestMethod]
        public void GetIndexFromArray_ReturnIndex_String()
        {
            //Arrange
            WordCounter newWordCounter = new WordCounter("dog", "cat and dog");

            //Act
            string paragraph = newWordCounter.GetParaGraph();
            string[] result = newWordCounter.StringToArray();
            string[] blah = paragraph.Split(' ');

            //Assert
            CollectionAssert.AreEqual(blah, result);
        }

        [TestMethod]
        public void RunNoArgConstructor_ReturnTheWordCount_Int()
        {
            //Arrange
            WordCounter newWordCounter = new WordCounter();

            //Act
            newWordCounter.SetWordToCount("blue,");
            newWordCounter.SetParagraph("the sky is blue, the oceans is blue, the dog is not blue");
            string paragraph = newWordCounter.GetParaGraph();
            string word = newWordCounter.GetWordToCount();
            string[] test = newWordCounter.StringToArray();
            int result = newWordCounter.GetResults();

            //Assert
            Assert.AreEqual(result,2);
        }

        [TestMethod]
        public void GetTheWordCount_ReturnTheWordCount_Int()
        {

            //Arrange
            WordCounter newWordCounter = new WordCounter("cat", "cat and cat");
            string paragraph = newWordCounter.GetParaGraph();
            string word = newWordCounter.GetWordToCount();
            string[] test = newWordCounter.StringToArray();

            //Act
            int result = newWordCounter.GetResults();

            //Assert
            Assert.AreEqual(result,2);
        }
    }
}
