using System;
using System.Collections.Generic;
using System.Linq;

namespace WordCounter
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
        public string GetSentence()
        {
            return _inputSentence;
        }
        public string[] SentenceSplitter()
        {
            string[] splitSentance = _inputSentence.Split(' ');
            return splitSentance;
        }
        public void score(String[] splitSentance)
        {
            foreach (string splitWord in splitSentance)
            {
                if (splitWord == _inputWord)
                {
                    Points += 1;
                }
            }

        }
        public int points()
        {
            return Points;
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
            Console.WriteLine("Give me a list of words or a sentence.");
            string sentence = Console.ReadLine();
            newRepeatCounter.SetSentence(sentence);
            newRepeatCounter.score(newRepeatCounter.SentenceSplitter());
            string result = newRepeatCounter.points() + " Time(s), you reused " + word + "." ;
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
