using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markov_Chains
{
    public class Logics
    {
        List<RootWord> rootWords;
        int wordsCount;
        public Logics(int wordsCount)
        {
            rootWords = new List<RootWord>();
            this.wordsCount = wordsCount;
        }
        public string[] FindNextWords(string rootWord, string nextWord)
        {
            foreach (var word in rootWords)
            {
                if(word.wordString.Equals(rootWord))
                {
                    return word.GetTopWords(nextWord);
                }
            }
            return null;
        }
        public void AddNewChains(string rootWord, string firstWord, string secondWord)
        {
            foreach (var word in rootWords)
            {
                if (word.wordString.Equals(rootWord))
                {
                    word.AddNewChain(firstWord, secondWord);
                }
            }
        }
        public void AddNewRoot(string rootWord)
        {
            rootWords.Add(new RootWord(wordsCount, rootWord, 3));
        }
    }
}
