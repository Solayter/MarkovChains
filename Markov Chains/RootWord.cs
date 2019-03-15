using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markov_Chains
{
    public class RootWord
    {
        public int globalId;
        public int localId;
        public string word;
        public List<NextWord> nextWords;
        public decimal[,] matrix;

        public RootWord(int globalId, byte matrixSize)
        {
            this.globalId = globalId;
            localId = 0;
            nextWords = new List<NextWord>();
            matrix = new decimal[matrixSize,matrixSize];
            ZerosForMatrix(matrixSize);
        }
        public void AddNextWord(string word)
        {
            nextWords.Add(new NextWord(word, nextWords.Count + 1));
        }
        private void ZerosForMatrix(byte matrixSize)
        {
            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    matrix[i, j] = 0;
                }
            }
        }
        
        public string[] GetWords()
        {
            string[] words = new string[3];
            return words;
        }

    }
}
