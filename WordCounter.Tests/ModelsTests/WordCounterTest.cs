using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounter
  {
    [TestMethod]
    public void SetWord_True()
   {
     //arrange
     string testword = "iLoveTests";
     RepeatCounter newRepeatCounter = new RepeatCounter();

     //act
     newRepeatCounter.SetWord(testword);
     string result = newRepeatCounter.GetWord();

     //assert
     Assert.AreEqual(testword, result);
   }
   [TestMethod]
   public void SetSentence_True()
   {
   //arrange
   string testsentence = "i Love Tests";
   RepeatCounter newRepeatCounter = new RepeatCounter();

   //act
   newRepeatCounter.SetSentence(testsentence);
   string result2 = newRepeatCounter.GetSentence();

   //assert
   Assert.AreEqual(testsentence, result2);
  }
    // [TestMethod]
    // public void ExampleTest_True()
    // {
    //   //arrange
    //   string testword =
    //   RepeatCounter NewRepeatCounter = new RepeatCounter();
    //   //act
    //   NewRepeatCounter.SentenceSplitter
    //   //assert
    }
  }
}
