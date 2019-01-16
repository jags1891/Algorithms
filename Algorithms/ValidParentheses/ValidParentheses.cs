﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidParentheses
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
                if (c == '{' || c == '[' || c == '(')
                    Open.Push(c);
                else if (Open.Count < 1 || ParanDictionary[Open.Pop()] != c)
                    return false;
            }

            if (Open.Count > 0)
                return false;

            return true;
        }
    }
}
