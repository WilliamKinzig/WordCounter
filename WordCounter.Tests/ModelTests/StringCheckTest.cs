using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class StringCheckTest
    {
        [TestMethod]
        public void GetStringToCount_ReturnStringsWorkingWith_String()
        {
            //Arrange
            StringCheck newStringCheck = new StringCheck("the","the yellow bus");

            //Act
            string toCount = newStringCheck.GetWordToCount();
            string toScan = newStringCheck.GetParaGraph();

            //Assert
            Assert.AreEqual(toScan, "the yellow bus");
        }

        [TestMethod]
        public void GetIndexFromArray_ReturnIndex_String()
        {
            //Arrange
            StringCheck newStringCheck = new StringCheck("dog", "cat and dog");

            //Act
            string paragraph = newStringCheck.GetParaGraph();
            string[] result = newStringCheck.StringToArray();
            string[] blah = paragraph.Split(' ');

            //Assert
            CollectionAssert.AreEqual(blah, result);
        }

        [TestMethod]
        public void RunNoArgConstructor_ReturnTheWordCount_Int()
        {
            //Arrange
            StringCheck newStringCheck = new StringCheck();

            //Act
            newStringCheck.SetWordToCount("blue,");
            newStringCheck.SetParagraph("the sky is blue, the oceans is blue, the dog is not blue");
            string paragraph = newStringCheck.GetParaGraph();
            string word = newStringCheck.GetWordToCount();
            string[] test = newStringCheck.StringToArray();
            int result = newStringCheck.GetResults();

            //Assert
            Assert.AreEqual(result,2);
        }

        [TestMethod]
        public void GetTheWordCount_ReturnTheWordCount_Int()
        {

            //Arrange
            StringCheck newStringCheck = new StringCheck("cat", "cat and cat");
            string paragraph = newStringCheck.GetParaGraph();
            string word = newStringCheck.GetWordToCount();
            string[] test = newStringCheck.StringToArray();

            //Act
            int result = newStringCheck.GetResults();

            //Assert
            Assert.AreEqual(result,2);
        }
    }
}
