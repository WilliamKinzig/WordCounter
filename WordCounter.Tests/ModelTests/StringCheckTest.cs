using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;
using System;
using System.Collections.Generic;


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
        public void GetTheWordCount_ReturnTheWordCount_Int()
        {
            //Arrange
            StringCheck newStringCheck = new StringCheck("cat", "cat and cat");
            string[] test = newStringCheck.StringToArray();

            //Act
            int result = newStringCheck.ArrayLoopCounter();

            //Assert
            Assert.AreEqual(result,2);
        }
    }
}


































//
//     //Act
//     string newParagraph = "Scooby Dooby Doo. Where are you?";
//     newWordSearcher.SetParagraph(newParagraph);
//     string result = newWordSearcher.GetParaGraph();
//
//     //Assert
//     Assert.AreEqual(newParagraph, result);
// }
