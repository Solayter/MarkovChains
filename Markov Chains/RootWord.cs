using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markov_Chains
{
    [Serializable]
    public class RootWord
    {
        /// <summary>
        /// Глобальный номер корневого слова.
        /// </summary>
        public int globalId;
        /// <summary>
        /// Локальный номер корневого слова. Всегда равен нулю.
        /// </summary>
        public int localId;
        /// <summary>
        /// Строка со словом.
        /// </summary>
        public string word;
        /// <summary>
        /// Список возможных слов, следующих за корневым.
        /// </summary>
        public List<NextWord> nextWords;
        /// <summary>
        /// Матрица соответствий для данного корневого слова.
        /// </summary>
        public decimal[,] matrix;
        /// <summary>
        /// Создание нового корневого слова.
        /// </summary>
        /// <param name="word">Строка со словом.</param>
        /// <param name="globalId">Глобальный номер корневого слова.</param>
        /// <param name="matrixSize">Максимальный размер матрицы соответствий.</param>
        public RootWord(string word, int globalId, byte matrixSize)
        {
            this.word = word;
            this.globalId = globalId;
            localId = 0;
            nextWords = new List<NextWord>();
            matrix = new decimal[matrixSize,matrixSize];
            ZerosForMatrix(matrixSize);
        }
        /// <summary>
        /// Создать новое возможное слово, следующее за корневым.
        /// </summary>
        /// <param name="word">Строка со словом.</param>
        public void AddNextWord(string word)
        {
            nextWords.Add(new NextWord(word, nextWords.Count + 1));
        }
        /// <summary>
        /// Заполнение матрицы соответствий нулями.
        /// </summary>
        /// <param name="matrixSize">Размер матрицы.</param>
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
        /// <summary>
        /// Получить массив самых популярных слов.
        /// </summary>
        /// <returns>Список самых популярных слов</returns>
        public string[] GetWords()
        {
            string[] words = new string[3];
            return words;
        }

    }
}
