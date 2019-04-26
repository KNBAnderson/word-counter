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
    public void WordMatch_CheckIfWordMatch_Int1()
    {
      RepeatCounter newCounter = new RepeatCounter();
      int result = newCounter.WordMatch("cat", "cat");
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void WordMatch_CheckIfWordMatchCaps_Int1()
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
  }
}
