using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markov_Chains
{
    public class Logics
    {
        /// <summary>
        /// Список корневых слов.
        /// </summary>
        private List<RootWord> rootWords;
        /// <summary>
        /// Количество корневых слов.
        /// </summary>
        private int rootWordsCount;
        /// <summary>
        /// Максимальный размер матрицы соответствий. Следовательно максимальнкое количество слов для каждого корневого слова.
        /// </summary>
        private byte matrixSize;
        /// <summary>
        /// Создание класса логики.
        /// </summary>
        /// <param name="matrixSize">Максимальный размер матрицы соответствий. Следовательно максимальнкое количество слов для каждого корневого слова.</param>
        public Logics(byte matrixSize)
        {
            rootWords = new List<RootWord>();
            rootWordsCount = 0;
            this.matrixSize = matrixSize;
        }
        /// <summary>
        /// Добавление нового корневого слова.
        /// </summary>
        /// <param name="word">Строка со словом.</param>
        public void AddRootWord(string word)
        {
            rootWords.Add(new RootWord(word, rootWordsCount++, matrixSize));
        }

        /// <summary>
        /// Добавление корневых слов для тестирования.
        /// </summary>
        public void AddTestData()
        {
            
        }
    }
}
