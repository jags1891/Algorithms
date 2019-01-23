using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsLibrary.DataStructures;

namespace AlgorithmsLibrary.Graphs
{
    /// <summary>
    /// To be implemented
    /// </summary>
    public class WordLadder
    {

        /// <summary>
        /// LeetCode Problem:
        /// Given two words (beginWord and endWord), and a dictionary's word list, 
        /// find the length of shortest transformation sequence from beginWord to endWord, such that:
        ///     1.  Only one letter can be changed at a time.
        ///     2.  Each transformed word must exist in the word list. Note that beginWord is not a transformed word.
        /// Note:
        ///     Return 0 if there is no such transformation sequence.
        ///     All words have the same length.
        ///     All words contain only lowercase alphabetic characters.
        ///     You may assume no duplicates in the word list.
        ///     You may assume beginWord and endWord are non-empty and are not the same.   
        /// </summary>
        /// <param name="beginWord"></param>
        /// <param name="endWord"></param>
        /// <param name="path"></param>
        /// <returns></returns>
        public int LadderLength(string beginWord, string endWord, ref string path)
        {
            HashSet<string> dic = MyLexicon.Instance.Dictionary;

            if (beginWord.Length != endWord.Length)
                throw new InvalidOperationException();

            if (!dic.Contains(endWord))
                return 0;

            int level = 0;
            int wordLength = beginWord.Length;

            Queue<string> queue = new Queue<string>();
            queue.Enqueue(beginWord);

            dic.Remove(beginWord);
            path += beginWord + " => ";

            while (queue.Count > 0)
            {
                level++;

                for(int levelItems = 0; levelItems < queue.Count; levelItems++)
                {
                    string Orignalword = queue.Dequeue();

                    for (int pos = 0; pos < wordLength; pos++)
                    {
                        StringBuilder word = new StringBuilder(Orignalword);

                        for (char c='a'; c <= 'z'; c++)
                        {
                            word[pos] = c;

                            string strWord = word.ToString();

                            if (strWord == endWord)
                            {
                                path += strWord;
                                return level + 1;
                            }
                                
                            if (!dic.Contains(strWord))
                                    continue;

                            dic.Remove(strWord);
                            path += strWord + " => ";

                            queue.Enqueue(strWord);
                        }

                    }

                }
            }

            return 0;
        }


    }
}
