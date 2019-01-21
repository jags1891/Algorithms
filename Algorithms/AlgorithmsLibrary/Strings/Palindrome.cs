namespace AlgorithmsLibrary.Strings
{
    public class Palindrome
    {
        /// <summary>
        /// Chek if the string is palidrome
        /// </summary>
        /// <param name="str"></param>
        /// <param name="recursive">true for recursive and false for itirative</param>
        /// <returns></returns>
        public bool isPalidrome(string str, bool recursive=true)
        {
            str = str.ToLower();
            if (recursive)
                return isPalindromUsingRecursion(str);

            return isPalindromItirative(str);
        }

        /// <summary>
        /// Check if the string is palidrome using recursion
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private bool isPalindromUsingRecursion(string str)
        {
            if (str.Length <= 1)
                return true;

            if (str[0] == str[str.Length - 1])
                return isPalindromUsingRecursion(str.Substring(1, str.Length - 2));

              return false;
        }

        /// <summary>
        /// Check if the string is palidrome itiratively
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private bool isPalindromItirative(string str)
        {
            if (str.Length <= 1)
                return true;

            int start = 0;
            int last = str.Length-1;

            while (start < last)
            {
                if (str[start] != str[last])
                    return false;
                start++;
                last--;
            }

            return true;
        }
    }
}
