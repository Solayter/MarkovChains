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
            AddTestData();
        }
        public string[] FindNextWords(string rootWord, string nextWord)
        {
            foreach (var word in rootWords)
            {
                if(word.Equals(rootWord))
                {
                    return word.GetTopWords(nextWord);
                }
            }
            return null;
        }
        public void AddTestData()
        {
            rootWords.Add(new RootWord(wordsCount, "пиджак", 2));
            rootWords[0].AddNewWord("черный");
            rootWords[0].AddNewWord("синий");
            rootWords[0].AddNewWord("белый");
            rootWords[0].AddNewWord("красный");
            rootWords[0].AddNewChain("пиджак", "черный", 0.4m);
            rootWords[0].AddNewChain("пиджак", "белый", 0.4m);
            rootWords[0].AddNewChain("пиджак", "синий", 0.1m);
            rootWords[0].AddNewChain("пиджак", "красный", 0.1m);
            string[] sas = rootWords[0].GetTopWords("пиджак");
        }

    }
}
