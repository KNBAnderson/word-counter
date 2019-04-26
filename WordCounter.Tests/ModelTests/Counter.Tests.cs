using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;
using System;
using System.Collections.Generic;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTest
  {

    [TestMethod]
    public void WordMatch_CheckIfWordMatch_int()
    {
      RepeatCounter newCounter = new RepeatCounter();
      int result = newCounter.WordMatch("cat", "cat");
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void WordMatch_CheckIfWordMatchCaps_int()
    {
      RepeatCounter newCounter = new RepeatCounter();
      int result = newCounter.WordMatch("cat", "Cat");
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void WordFilter_ReturnWordOnlyAlpha_string()
    {
      RepeatCounter newCounter = new RepeatCounter();
      string result = newCounter.WordFilter("cat,");
      Assert.AreEqual("cat", result);
    }

    [TestMethod]
    public void WordMatch_CheckIfWordsMatchPunctInWordToMatch_int()
    {
      RepeatCounter newCounter = new RepeatCounter();
      int result = newCounter.WordMatch("cat", ".c.A.t.,");
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void WordMatch_CheckIfWordsMatchPunctInBothArguemts_int()
    {
      RepeatCounter newCounter = new RepeatCounter();
      int result = newCounter.WordMatch("c...a!t", ".c.A.t.,");
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void WordMatch_CheckIfWordsMatchPlural_int()
    {
      RepeatCounter newCounter = new RepeatCounter();
      int result = newCounter.WordMatch("cat", "cats");
      Assert.AreEqual(0, result);
    }
  }
}
