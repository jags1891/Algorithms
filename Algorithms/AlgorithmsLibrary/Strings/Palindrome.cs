using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLibrary.Strings
{
    public class Palindrome
    {
        public bool isPalidrome(string str, bool recursive)
        {
            str = str.ToLower();
            if (recursive)
                return isPalindromUsingRecursion(str);

            return isPalindromItirative(str);

        }

        private bool isPalindromUsingRecursion(string str)
        {
            if (str.Length <= 1)
                return true;

            if (str[0] == str[str.Length - 1])
                return isPalindromUsingRecursion(str.Substring(1, str.Length - 2));

              return false;
        }

        private bool isPalindromItirative(string str)
        {
           //To be implemented

            return false;
        }
    }
}
