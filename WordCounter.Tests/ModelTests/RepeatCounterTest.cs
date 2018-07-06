//imports the MSTest framework for us to use
using Microsoft.VisualStudio.TestTools.UnitTesting;

//imports the Calendar namespace from the Calendar project for use in our tests
using WordCounter;

namespace WordCounter.Tests
{
    [TestClass] //This tells MSTest that the following class contains tests to be run
    public class IsStringTest
    {
        [TestMethod]
        public void IsUserWord_ActuallyAString_False()
        {
            StringCheck stringWord = new StringCheck();
            Assert.AreEqual("aword", stringWord.StringToArray("aword"));
        }

        // [TestMethod]
        // public void IsLeapYear_NumberNotDivisibleByFour_False()
        // {
        //   RepeatCounter testLeapYear = new RepeatCounter();
        //   Assert.AreEqual(false, testLeapYear.IsStringTest(1999));
        // }
        //
        // [TestMethod]
        // public void IsLeapYear_MultiplesOfOneHundred_False()
        // {
        //   RepeatCounter testLeapYear = new RepeatCounter();
        //   Assert.AreEqual(false, testLeapYear.IsStringTest(1900));
        // }
        //
        // [TestMethod]
        // public void IsLeapYear_MultiplesOfFourHundred_True()
        // {
        //   RepeatCounter testLeapYear = new RepeatCounter();;
        //   Assert.AreEqual(true, testLeapYear.IsStringTest(2000));
        // }

        // //This tells the compiler that the following code block is an individual
        // //test that should be run by MSTest
        // [TestMethod]
        //
        // //This is the test.
        // //naming convention is basically
        // //MethodToBeTested_BehaviorToBeTested_ExpectedResultOfTest
        // public void StringToArray_PushStringToArray_True()
        // {
        //     // eventually your testing code will go here
        //
        // }
    }
}













/*****************************************************************************/
/*****************************************************************************/
//     string str = null;
//     string[] strArr = null;
//     int count = 0;
//     str = "CSharp split test";
//     char[] splitchar = { ' ' };
//     strArr = str.Split(splitchar);
//     for (count = 0; count <= strArr.Length - 1; count++)
//     {
//         MessageBox.Show(strArr[count]);
//     }
/*****************************************************************************/
/*****************************************************************************/
// class Program
// {
//     static void Main()
//     {
//         string s1 = "Sam's first name is Sam.";
//         string s2 = "Dot Net Perls is about Dot Net";
//         string s3 = "No duplicates here";
//         string s4 = "aaaa";
//
//         Console.WriteLine(TextTool.CountStringOccurrences(s1, "Sam"));  // 2
//         Console.WriteLine(TextTool.CountStringOccurrences(s1, "cool")); // 0
//         Console.WriteLine(TextTool.CountStringOccurrences(s2, "Dot"));  // 2
//         Console.WriteLine(TextTool.CountStringOccurrences(s2, "Net"));  // 2
//         Console.WriteLine(TextTool.CountStringOccurrences(s3, "here")); // 1
//         Console.WriteLine(TextTool.CountStringOccurrences(s3, " "));    // 2
//         Console.WriteLine(TextTool.CountStringOccurrences(s4, "aa"));   // 2
//     }
// }
//
// /// <summary>
// /// Contains static text methods.
// /// Put this in a separate class in your project.
// /// </summary>
// public static class TextTool
// {
//     /// <summary>
//     /// Count occurrences of strings.
//     /// </summary>
//     public static int CountStringOccurrences(string text, string pattern)
//     {
//         // Loop through all instances of the string 'text'.
//         int count = 0;
//         int i = 0;
//         while ((i = text.IndexOf(pattern, i)) != -1)
//         {
//             i += pattern.Length;
//             count++;
//         }
//         return count;
//     }
// }
/*****************************************************************************/
/*****************************************************************************/
