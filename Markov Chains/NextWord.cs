using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markov_Chains
{
    public class NextWord
    {
        public int localId;
        public int numberOfRepeats;
        public string word;
        public List<NextWord> nextWords;


        public NextWord(string word, int localId)
        {
            this.word = word;
            this.localId = localId;
            nextWords = new List<NextWord>();
        }
        public void AddNextWord(string word)
        {
            
        }
        public string[] GetWords()
        {
            string[] words = new string[3];
            return words;
        }
    }
}
