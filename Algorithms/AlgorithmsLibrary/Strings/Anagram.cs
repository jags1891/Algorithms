namespace AlgorithmsLibrary.Strings
{
    public class Anagram
    {
        static int NO_OF_CHAR = 256; //8 bit extended ASCHII

        /// <summary>
        /// Returns true if word2 is an Anagram of word1
        /// </summary>
        /// <param name="word1"></param>
        /// <param name="word2"></param>
        /// <returns>Returns true if word2 is an Anagram of word1 else returns false</returns>
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
