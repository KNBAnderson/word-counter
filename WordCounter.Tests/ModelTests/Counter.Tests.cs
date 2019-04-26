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
      // any necessary logic to prep for test; instantiating new classes, etc.
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void WordMatch_CheckIfWordMatchCaps_Int1()
    {
      RepeatCounter newCounter = new RepeatCounter();
      int result = newCounter.WordMatch("cat", "Cat");
      // any necessary logic to prep for test; instantiating new classes, etc.
      Assert.AreEqual(1, result);
    }
  }
}
