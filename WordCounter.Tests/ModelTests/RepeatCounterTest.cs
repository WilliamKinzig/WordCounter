using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class WordSearcherTest
    {
        [TestMethod]
        public void GetStringToCount_ReturnStringsWorkingWith_String()
        {
            //Arrange
            WordSearcher newWordSearcher = new WordSearcher("the","the yellow bus");

            //Act
            string toCount = newWordSearcher.GetWordToCount();
            string toScan = newWordSearcher.GetParaGraph();

            //Assert
            //Assert.AreEqual(toCount, "the");
            Assert.AreEqual(toScan, "the yellow bus");
        }

        [TestMethod]
        public void GetIndexFromArray_ReturnIndex_String()
        {
            //Arrange
            WordSearcher newWordSearcher = new WordSearcher("dog", "cat and dog");

            //Act
            string paragraph = newWordSearcher.GetParaGraph();
            string result = newWordSearcher.StringToArray(paragraph);
            string test = newWordSearcher.GetWordToCount();

            //Assert
            Assert.AreEqual(test, result); //use (paragraph, result) to check array
        }



    }
}

































// [TestMethod]
// public void GetSetWordToFind_ReturnsWordToFind_String()
// {
//     //Arrange
//     string wordToCount = "word";
//     WordSearcher newWordSearcher = new WordSearcher(wordToCount);
//
//     //Act
//     string updatedWordCount= "blah";
//     newWordSearcher.SetWordCount(updatedWordCount);
//     string result = newWordSearcher.GetWordToCount();
//
//     //Assert
//     Assert.AreEqual(updatedWordToFind, result);
// }
//
// [TestMethod]
// public void GetSetParaGraphToScan_ReturnParagraphToScan_String()
// {
//     //Arrange
//     string paragraphToScanThrough = "para to scan through.";
//     WordSearcher newWordSearcher = new WordSearcher(paragraphToScanThrough);
//
//     //Act
//     string newParagraph = "Scooby Dooby Doo. Where are you?";
//     newWordSearcher.SetParagraph(newParagraph);
//     string result = newWordSearcher.GetParaGraph();
//
//     //Assert
//     Assert.AreEqual(newParagraph, result);
// }
