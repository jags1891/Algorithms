using System.Collections.Generic;

namespace AlgorithmsLibrary.Strings
{
    /// <summary>
    /// 
    /// </summary>
    public class ProblemSett1
    {
        /// <summary>
        /// Retrun 1st non repeating char of the string
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public char GetNonRepeatingChar(string str)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();

            char res = ' ';

            foreach (char c in str)
            {
                if (dic.ContainsKey(c))
                    dic[c]++;
                else
                    dic[c] = 1;

                if (dic[c] == 1)
                    res = c;
            }

            // To return First non repeated char
            foreach (char c in str)
            {
                if (dic[c] == 1)
                    return c;
            }

            return res;
        }

        static int NO_OF_CHAR = 256; //8 bit extended ASCHII

        /// <summary>
        /// using array
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public char GetNonRepeatingChar2(string str)
        {
            int[] temp = new int[NO_OF_CHAR];

            foreach (char c in str)
                temp[c]++;

            // To return First non repeated char
            foreach (char c in str)
                if (temp[c] == 1)
                    return c;

            return ' ';
        }

        /// <summary>
        /// Check if edit distance between two strings is one
        /// An edit between two strings is one of the following changes.
        ///     Add a character
        ///     Delete a character
        ///     Change a character
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public bool IsOneAway(string s1, string s2)
        {
            if (s1.Length - s2.Length > 1 || s2.Length - s1.Length > 1)
                return false;
  
            int diffCount = 0;
            int s1Ind = 0;
            int s2Ind = 0;

            while(s1Ind < s1.Length && s2Ind < s2.Length)
            {
                if(s1[s1Ind]==s2[s2Ind])
                {
                    s1Ind++;
                    s2Ind++;
                }
                else if(s1.Length> s2.Length)
                {
                    diffCount++;
                    s1Ind++;
                }
                else if(s1.Length < s2.Length)
                {
                    diffCount++;
                    s2Ind++;
                }
                else
                {
                    diffCount++;
                    s2Ind++;
                    s1Ind++;
                }

                if (diffCount > 1)
                    return false;
            }

            return true;
        }

              
    }

}
