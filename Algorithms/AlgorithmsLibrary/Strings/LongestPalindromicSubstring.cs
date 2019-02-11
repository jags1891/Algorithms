namespace AlgorithmsLibrary.Strings
{
    public class LongestPalindromicSubstring
    {
        /// <summary>
        /// To be improved
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string LongestPalindrome(string s)
        {
            if (s.Length < 2)
                return s;

            int maxLen = 0;
            int currLen = 0;
            string temp = "";

            string LongesPalindrome = "";
            for (int i = 0; i < s.Length - 1; i++)
            {
                temp = s.Substring(i);
                currLen = isPalindrome(temp);
                if (currLen > 0)
                {
                    maxLen = currLen;
                    LongesPalindrome = temp;
                    break;
                }

            }

            for (int i = s.Length ; i > 0; i--)
            {
                temp = s.Substring(0, i - 1);
                currLen = isPalindrome(temp);
                if (currLen > 0 && currLen > maxLen)
                {
                    maxLen = currLen;
                    LongesPalindrome = temp;
                    break;
                }

            }

            for (int i = 0; i < s.Length / 2; i++)
            {
                temp = s.Substring(i, s.Length - i - i);
                currLen = isPalindrome(temp);

                if (currLen > 0 && currLen > maxLen)
                {
                    maxLen = currLen;   
                    LongesPalindrome = temp;
                    break;
                }
            }


            return LongesPalindrome;


            }

        private int isPalindrome(string s)
        {
            if (s.Length == 1)
                return 1;

            int len = s.Length;

            for (int i = 0; i < len / 2; i++)
            {
                if (s[i] != s[len- i-1 ]) 
                     return 0;
            }

            return len;
        }
    }
}
