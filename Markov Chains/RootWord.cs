using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markov_Chains
{
    public class RootWord
    {
        public List<string> wordDict;
        public decimal[,,] matrix;
        public string wordString;
        public int wordsCount;
        public int outWordsCount;

        public RootWord(int wordsCount, string wordString, int outWordsCount)
        {
            wordDict = new List<string>();
            matrix = new decimal[wordsCount, wordsCount, 2];
            this.wordString = wordString;
            this.wordsCount = wordsCount;
            this.outWordsCount = outWordsCount;
            wordDict.Add(wordString);
        }
    
        public void AddNewWord(string wordString)
        {
            int ind;
            foreach(var word in wordDict)
            {
                if(word.Equals(wordString))
                {
                    ind = wordDict.IndexOf(word);
                    break;
                }
                wordDict.Add(wordString);
                break;
            }
        }
        public void AddNewChain(string firstWord, string secondWord, decimal freq)
        {
            int firstInd = 0;
            int secondInd = 0;
            foreach (var word in wordDict)
            {
                if (word.Equals(firstWord))
                    firstInd = wordDict.IndexOf(word);
                if (word.Equals(secondWord))
                    secondInd = wordDict.IndexOf(word);
            }
            matrix[firstInd, secondInd, 0] = freq;
        }
        public string[] GetTopWords(string thisWord)
        {
            int ind = 0;
            int[] indexes = new int[outWordsCount];
            string[] output = new string[outWordsCount];
            decimal[] buffer = new decimal[wordsCount];

            foreach (var word in wordDict)
            {
                if (word.Equals(thisWord))
                {
                    ind = wordDict.IndexOf(word);
                    break;
                }
            }
            for (int i = 0; i < wordsCount; i++)
            {
                buffer[i] = matrix[ind, i, 0];
            }
            
            for (int i = 0; i < outWordsCount; i++)
            {
                indexes[i] = Array.IndexOf(buffer, buffer.Max());
                buffer[indexes[i]] = 0;
            }
            for (int i = 0; i < outWordsCount; i++)
            {
                output[i] = wordDict[indexes[i]];
            }
            return output;
        }


    }
}
