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

    [TestMethod]
    public void WordCountInASentence_CheckCountOfWordInSentence1_int()
    {
      RepeatCounter newCounter = new RepeatCounter();
      int result = newCounter.WordCountInASentence("cat", "I am not a cat");
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void WordCountInASentence_CheckCountOfWordInSentence0_int()
    {
      RepeatCounter newCounter = new RepeatCounter();
      int result = newCounter.WordCountInASentence("cat", "I like cats.");
      Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void WordCountInASentence_CheckCountOfWordInSentence2_int()
    {
      RepeatCounter newCounter = new RepeatCounter();
      int result = newCounter.WordCountInASentence("cat", "Once a cat, always a cat.");
      Assert.AreEqual(2, result);
    }

    [TestMethod]
    public void WordCountInASentence_CheckCountOfWordInSentence3_int()
    {
      RepeatCounter newCounter = new RepeatCounter();
      int result = newCounter.WordCountInASentence("cat", "Cat, the cat, plays with toys for cats and dogs, even though she is a cat, not a dog.");
      Assert.AreEqual(3, result);
    }

    [TestMethod]
    public void WordCountInASentence_CheckCountOfWordInSentence8_int()
    {
      RepeatCounter newCounter = new RepeatCounter();
      int result = newCounter.WordCountInASentence("buffalo", "Buffalo buffalo Buffalo buffalo buffalo buffalo Buffalo buffalo.");
      Assert.AreEqual(8, result);
    }

    [TestMethod]
    public void WordCountInASentence_CheckCountOfWordInSentence4_int()
    {
      RepeatCounter newCounter = new RepeatCounter();
      int result = newCounter.WordCountInASentence("blah", "Blah blah, other bl4h. Wait, that's not a bla.h. But will bla.h count?");
      Assert.AreEqual(4, result);
    }
  }
}
