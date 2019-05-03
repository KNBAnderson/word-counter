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
    public void FindWordCount_CheckIfWordMatch_int()
    {
      RepeatCounter newCounter = new RepeatCounter("cat", "cat");
      newCounter.FindWordCount();
      int result = newCounter.WordCount;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void FindWordCount_CheckIfWordMatchCaps_int()
    {
      RepeatCounter newCounter = new RepeatCounter("cat", "Cat");
      newCounter.FindWordCount();
      int result = newCounter.WordCount;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void WordFilter_ReturnWordOnlyAlpha_string()
    {
      RepeatCounter newCounter = new RepeatCounter("cat", "cat,");
      string result = newCounter.WordFilter("cat,");
      Assert.AreEqual("cat", result);
    }

    [TestMethod]
    public void FindWordCount_CheckIfWordsMatchPunctInWordToMatch_int()
    {
      RepeatCounter newCounter = new RepeatCounter("cat", ".c.A.t.,");
      newCounter.FindWordCount();
      int result = newCounter.WordCount;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void FindWordCount_CheckIfWordsMatchPunctInBothArguemts_int()
    {
      RepeatCounter newCounter = new RepeatCounter("c...a!t", ".c.A.t.,");
      newCounter.FindWordCount();
      int result = newCounter.WordCount;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void FindWordCount_CheckIfWordsMatchPlural_int()
    {
      RepeatCounter newCounter = new RepeatCounter("cats", "cat");
      newCounter.FindWordCount();
      int result = newCounter.WordCount;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void FindWordCount_CheckIfWordsMatchPluralES_int()
    {
      RepeatCounter newCounter = new RepeatCounter("machine", "machines");
      newCounter.FindWordCount();
      int result = newCounter.WordCount;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void FindWordCount_CheckIfWordsMatchPluralIES_int()
    {
      RepeatCounter newCounter = new RepeatCounter("puppy", "PUPPIES");
      newCounter.FindWordCount();
      int result = newCounter.WordCount;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void FindWordCount_CheckCountOfWordInSentence1_int()
    {
      RepeatCounter newCounter = new RepeatCounter("cat", "I am not a cat");
      newCounter.FindWordCount();
      int result = newCounter.WordCount;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void FindWordCount_CheckCountOfWordInSentence0_int()
    {
      RepeatCounter newCounter = new RepeatCounter("cat", "I like cats.");
      newCounter.FindWordCount();
      int result = newCounter.WordCount;
      Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void FindWordCount_CheckCountOfWordInSentence2_int()
    {
      RepeatCounter newCounter = new RepeatCounter("cat", "Once a cat, always a cat.");
      newCounter.FindWordCount();
      int result = newCounter.WordCount;
      Assert.AreEqual(2, result);
    }

    [TestMethod]
    public void FindWordCount_CheckCountOfWordInSentence4_int()
    {
      RepeatCounter newCounter = new RepeatCounter("cat", "Cat, the cat, plays with toys for cats and dogs, even though she is a cat, not a dog.");
      newCounter.FindWordCount();
      int result = newCounter.WordCount;
      Assert.AreEqual(4, result);
    }

    [TestMethod]
    public void FindWordCount_CheckCountOfWordInSentence8_int()
    {
      RepeatCounter newCounter = new RepeatCounter("buffalo", "Buffalo buffalo Buffalo buffalo buffalo buffalo Buffalo buffalo.");
      newCounter.FindWordCount();
      int result = newCounter.WordCount;
      Assert.AreEqual(8, result);
    }

    [TestMethod]
    public void FindWordCount_CheckCountOfWordInSentence4WithPunct_int()
    {
      RepeatCounter newCounter = new RepeatCounter("blah", "Blah blah, other bl4h. Wait, that's not a bla.h. But will bla.h count?");
      newCounter.FindWordCount();
      int result = newCounter.WordCount;
      Assert.AreEqual(4, result);
    }
  }
}
