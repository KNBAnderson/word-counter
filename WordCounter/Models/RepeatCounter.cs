using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    public int WordMatch(string word, string wordToCompare)
    {
      word = word.ToLower();
      wordToCompare = word.ToLower();
      if (word == wordToCompare)
      {
        return 1;
      }
      return 0;
    }
  }
}
