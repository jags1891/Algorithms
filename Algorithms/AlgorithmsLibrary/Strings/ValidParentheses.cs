using System.Collections.Generic;

namespace AlgorithmsLibrary.Strings
{
    public class ValidParentheses
    {
        public bool IsValid(string s)
        {
            Dictionary<char, char> ParanDictionary = new Dictionary<char, char>();
            ParanDictionary.Add('{', '}');
            ParanDictionary.Add('[', ']');
            ParanDictionary.Add('(', ')');

            Stack<char> Open = new Stack<char>();

            foreach (char c in s)
            {
                if (ParanDictionary.ContainsKey(c))
                    Open.Push(c);
                else if (Open.Count < 1 || ParanDictionary[Open.Pop()] != c)
                    return false;
            }

            return (Open.Count < 1);
        }
    }
}
