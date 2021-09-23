using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble;

namespace Scrabble.Tests
{
  [TestClass]
  public class WordTests
  {
    [TestMethod]
    public void GetScore_ReturnsScore_1()
    {
      //Arrange
      string inputString = "a";
      Word newWord = new Word(inputString);
      int expectedResult = 1;
      //Act
      int result = newWord.GetScore();
      //Assert
      Assert.AreEqual(expectedResult, result);
    }
    [TestMethod]
    public void GetScore_ReturnsScore_3()
    {
      //Arrange
      string inputString = "aaa";
      Word newWord = new Word(inputString);
      int expectedResult = 3;
      //Act
      int result = newWord.GetScore();
      //Assert
      Assert.AreEqual(expectedResult, result);
    }
  }
}