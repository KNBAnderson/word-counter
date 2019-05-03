using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    public string Word {get; set;}
    public string Phrase {get; set;}
    public int WordCount {get; set;}
    public static List<RepeatCounter> CounterList {get; set;} = new List<RepeatCounter> {};
    public int Id {get; set;}

    public RepeatCounter (string word, string phrase)
    {
      Word = word;
      Phrase = phrase;
      WordCount = this.FindWordCount();
      CounterList.Add(this);
      Id = CounterList.Count;
    }

    public string WordFilter(string word)
    {
      char[] wordArray = word.ToLower().ToCharArray();
      string filteredWord = "";
      //The below statement modifies words that could be plural as well as words that end in y and would have special plural rules
      if (wordArray[wordArray.Length - 1] == 's' ||  wordArray[wordArray.Length - 1] == 'y') {
        wordArray[wordArray.Length - 1] = '-';
        if (wordArray[wordArray.Length - 2] == 'e' && wordArray[wordArray.Length - 3] == 'i') {
          wordArray[wordArray.Length - 2] = '-';
          wordArray[wordArray.Length - 3] = '-';
        }
      }
      foreach (char letter in wordArray) {
        if (Char.IsLetter(letter)) {
          filteredWord += letter;
        }
      }
      return filteredWord;
    }

    public int FindWordCount()
    {
      int wordCounter = 0;
      string[] sentenceArray = Phrase.Split(" ");
      foreach(string sentWord in sentenceArray)
      {
        if (WordFilter(Word) == WordFilter(sentWord))
        {
          wordCounter++;
        }
      }
      return wordCounter;
    }

    public static void ClearAll()
    {
      CounterList.Clear();
    }

    public static RepeatCounter Find(int searchId)
    {
      return CounterList[searchId-1];
    }
  }
}
