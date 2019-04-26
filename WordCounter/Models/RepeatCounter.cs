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
      if (wordArray[wordArray.Length - 1] == 's' || wordArray[wordArray.Length - 1] == 'S' || wordArray[wordArray.Length - 1] == 'y' ||
      wordArray[wordArray.Length - 1] == 'Y') {
        wordArray[wordArray.Length - 1] = '-';
        if ((wordArray[wordArray.Length - 2] == 'e' || wordArray[wordArray.Length - 2] == 'E') && (wordArray[wordArray.Length - 3] == 'i' || wordArray[wordArray.Length - 3] == 'I')) {
          wordArray[wordArray.Length - 2] = '-';
          wordArray[wordArray.Length - 3] = '-';
        }
      }
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
