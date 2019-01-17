using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLibrary
{
    public class Anagram
    {
        static int NO_OF_CHAR = 256; //8 bit extended ASCHII

        public bool isAnagram(string word1, string word2)
        {
            word1 = word1.Trim();
            word2 = word2.Trim();

            if (word1.Length != word2.Length)
                return false;

            int[] temp = new int[NO_OF_CHAR];

            for(int i=0; i<word1.Length; i++)
            {
                temp[word1[i]]++;
                temp[word2[i]]--;
            }

            for(int i=0; i<NO_OF_CHAR;i++)
            {
                if (temp[i] != 0)
                    return false;
            }

            return true;
        }

    }
}
