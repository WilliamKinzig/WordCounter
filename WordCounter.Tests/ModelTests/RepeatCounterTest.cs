using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordSearcherTest
  {
    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      //Arrange
      string description = "Walk the dog.";
      WordSearcher newWordSearcher = new WordSearcher(description);

      //Act
      string updatedWordToFind = "blah";
      newWordSearcher.SetDescription(updatedWordToFind);
      string result = newWordSearcher.GetDescription();

      //Assert
      Assert.AreEqual(updatedWordToFind, result);
    }


  }
}
