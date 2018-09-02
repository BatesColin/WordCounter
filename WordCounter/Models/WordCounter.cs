using System;
using System.Collections.Generic;
using System.Linq;

namespace WordCounter.Models
{
    public class RepeatCounter
    {
        private string _inputSentence;
        private string _inputWord;
        private int Points = 0;
        public void SetWord(string inputWord)
        {
            _inputWord = inputWord;
        }
        public string GetWord()
        {
            return _inputWord;
        }
        public void SetSentence(string inputSentence)
        {
            _inputSentence = inputSentence;
        }
         public int GetScore()
        {
        return Points;
        }
        public string GetSentence()
        {
            return _inputSentence;
        }
        public string[] SentenceSplitter()
        {
            string[] splitSentance = _inputSentence.Split(' ');
            return splitSentance;
        }
        public void Score(String[] splitSentance)
        {
            foreach (string splitWord in splitSentance)
            {
                if (splitWord == _inputWord)
                {
                    Points += 1;
                }
            }

        }
       
    }
    // public class Program
    // {
    //     public static void Main()
    //     {
    //         RepeatCounter newRepeatCounter = new RepeatCounter();
    //         RepeatCounter otherRepeatCounter = new RepeatCounter();
    //         Console.WriteLine("give me any word");
    //         string word = Console.ReadLine();
    //         newRepeatCounter.SetWord(word);
    //         otherRepeatCounter.SetWord(word);
    //         Console.WriteLine("Give me a list of words or a sentence.");
    //         string sentence = Console.ReadLine();
    //         newRepeatCounter.SetSentence(sentence);
    //         Console.WriteLine("Give me another list of words or a sentence.");
    //         sentence = Console.ReadLine();
    //         otherRepeatCounter.SetSentence(sentence);
    //         newRepeatCounter.score(newRepeatCounter.SentenceSplitter());
    //         otherRepeatCounter.score(otherRepeatCounter.SentenceSplitter());
    //         string result = newRepeatCounter.points() + " Time(s), you reused " + word + "." ;
    //         string result2 = otherRepeatCounter.points() + " Time(s), you reused " + word + ".";
    //         Console.WriteLine(result);
    //         Console.WriteLine(result2);
    //         Console.ReadLine();
    //     }
    // }
}
