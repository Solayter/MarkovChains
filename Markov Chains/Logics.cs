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

        public void AddTestData()
        {
            rootWords.Add(new RootWord(wordsCount, "пиджак", 3));
            rootWords.Add(new RootWord(wordsCount, "дом", 3));
            rootWords.Add(new RootWord(wordsCount, "хлеб", 3));
            rootWords.Add(new RootWord(wordsCount, "диван", 3));
            rootWords.Add(new RootWord(wordsCount, "ручка", 3));
            rootWords.Add(new RootWord(wordsCount, "стул", 3));
            rootWords.Add(new RootWord(wordsCount, "компьютер", 3));
            rootWords.Add(new RootWord(wordsCount, "лампа", 3));
            rootWords.Add(new RootWord(wordsCount, "книга", 3));
            rootWords.Add(new RootWord(wordsCount, "окно", 3));
            //rootWords[0].AddNewWord("черный");
            //rootWords[0].AddNewWord("синий");
            //rootWords[0].AddNewWord("белый");
            //rootWords[0].AddNewWord("красный");
            rootWords[1].AddNewChain("дом", "зеленый");
            rootWords[0].AddNewChain("пиджак", "черный");
            rootWords[0].AddNewChain("пиджак", "черный");
            rootWords[0].AddNewChain("пиджак", "черный");
            rootWords[0].AddNewChain("пиджак", "черный");
            rootWords[0].AddNewChain("черный", "размер");
            rootWords[0].AddNewChain("черный", "большой");
            rootWords[0].AddNewChain("черный", "детский");
            rootWords[0].AddNewChain("размер", "M");
            rootWords[0].AddNewChain("размер", "L");
            rootWords[0].AddNewChain("размер", "S");
            rootWords[0].AddNewChain("пиджак", "белый");
            rootWords[0].AddNewChain("пиджак", "белый");
            rootWords[0].AddNewChain("пиджак", "белый");
            rootWords[0].AddNewChain("пиджак", "синий");
            rootWords[0].AddNewChain("пиджак", "синий");
            rootWords[0].AddNewChain("пиджак", "красный");

            //string[] sas = rootWords[0].GetTopWords("пиджак");
        }

    }
}
