using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    public string WordFilter (string word)
    {
      char[] wordArray = word.ToCharArray();
      string filteredWord = "";
      foreach (char letter in wordArray) {
        if (Char.IsLetter(letter)) {
          filteredWord += letter;
        }
      }
      return filteredWord.ToLower();
    }

    public int WordMatch(string word, string wordToCompare)
    {
      if (WordFilter(word) == WordFilter(wordToCompare))
      {
        return 1;
      }
      return 0;
    }

    public int WordCountInASentence(string word, string sentence)
    {
      int wordCount = 0;
      string[] sentenceArray = sentence.Split(" ");
      foreach(string sentWord in sentenceArray)
      {
        wordCount += WordMatch(word, sentWord);
      }
      return wordCount;
    }
  }
}
