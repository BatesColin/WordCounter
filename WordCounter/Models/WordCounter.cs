using System;
using System.Collections.Generic;

namespace WordCounter
{
  public class RepeatCounter
  {
    private string _inputWord;
    public void SetWord(string inputWord)
    {
      _inputWord = inputWord;
    }
    public string GetWord()
    {
      return _inputWord;
    }

  }
  public class Program
  {
    public static void Main()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter();
      Console.WriteLine("give me any word");
      string word = Console.ReadLine();
      newRepeatCounter.SetWord(word);

    }
  }
}
